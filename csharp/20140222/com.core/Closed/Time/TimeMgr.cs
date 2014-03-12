using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.core
{
    public class TimeMgr : IIntStream
    {
        public void serialize(ISerialize nSerialize)
        {
            string strClassify = null;
            nSerialize.runString(ref strClassify, "classify");
            mClassify = GenerateId.runCommon(strClassify);

            nSerialize.runIntStreams(ref mTimes, "times", "time");
        }

        public string streamName()
        {
            return "timeMgr";
        }

        public bool checkClosed(DateTime nDateTime, DateTime nStartTime, DateTime nSaveTime, int nClosed)
        {
            if (!mTimes.ContainsKey(nClosed))
            {
                LogService logService = __singleton<LogService>.instance();
                logService.logError(TAG, string.Format("checkClosed[{0}]", nClosed));
                return false;
            }
            Time time = mTimes[nClosed];
            return time.checkClosed(nDateTime, nStartTime, nSaveTime);
        }

        public void runOpen(string nUrl)
        {
            XmlReader xmlReader = new XmlReader();
            xmlReader.openUrl(nUrl);
            xmlReader.selectStream(streamName());
            this.serialize(xmlReader);
            xmlReader.runClose();
        }

        public int getKey()
        {
            return mClassify;
        }

        public TimeMgr()
        {
            mTimes = new Dictionary<int, Time>();
            mClassify = 0;
        }

        static readonly string TAG = typeof(TimeMgr).Name;
        Dictionary<int, Time> mTimes;
        int mClassify;
    }
}
