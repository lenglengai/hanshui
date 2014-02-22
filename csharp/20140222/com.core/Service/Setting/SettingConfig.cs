using System.IO;

namespace com.core
{
    public class SettingConfig : IHeadstream
    {
        public void headSerialize(ISerialize nSerialize) 
        {
            nSerialize.runInt16(ref mServerCount, "serverCount");
            nSerialize.runInt16(ref mServerId, "serverId");
            nSerialize.runInt16(ref mLower, "lower");
            nSerialize.runInt32(ref mHigh, "high");
        }

        public string streamName()
        {
            return "settingConfig";
        }

        public bool checkServerId(uint nServerId)
        {
            return (mServerId == nServerId);
        }

        public void setServerId(short nServerId) 
        {
            mServerId = nServerId;
        }

        public short getServerId() 
        {
            return mServerId;
        }

        public void setServerCount(short nServerCount)
        {
            mServerCount = nServerCount;
        }

        public short getServerCount()
        {
            return mServerCount;
        }

        public int checkVersion(int nVersion)
        {
            int high = nVersion >> 12;
            int lower = nVersion & 0xFFF;
            if (high != mHigh){
                return OpCode.MUSTUPDATE;
            }
            if (lower != mLower){
                return OpCode.HAVEUPDATE;
            }
            return OpCode.SUCESS;
        }

        public void runPreinit(string nPath = null)
        {
            mSystemPath = Path.Combine(nPath, @"bin");
            this.initConfig();
        }

        void initConfig()
        {
            string streamName_ = this.streamName();
            string settingConfigUrl_ = @"config/setting.xml";
            XmlReader xmlReader_ = new XmlReader();
            xmlReader_.openUrl(settingConfigUrl_);
            xmlReader_.selectStream(streamName_);
            this.headSerialize(xmlReader_);
            xmlReader_.runClose();
        }

        public string systemPath() {
            return mSystemPath;
        }

        public SettingConfig()
        {
            mSystemPath = null;
            mServerCount = 0;
            mServerId = 0;
            mLower = 0;
            mHigh = 0;
        }

        string mSystemPath;
        short mServerCount;
        short mServerId;
        short mLower;
        int mHigh;
    }
}
