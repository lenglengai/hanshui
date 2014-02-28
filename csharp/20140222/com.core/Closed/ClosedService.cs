using System.Collections.Generic;

namespace com.core
{
    public class ClosedService : IStream
    {
        public void serialize(ISerialize nSerialize)
        {
            nSerialize.runIntStreams(ref mClosedMgrs, "closeds", "closed");
        }

        public void runPreinit()
        {
            XmlReader xmlReader = new XmlReader();
            xmlReader.openUrl("config/closed.xml");
            this.serialize(xmlReader);
            xmlReader.runClose();
        }

        public bool checkClosed(ClosedArgs nClosedArgs)
        {
            if (!mClosedMgrs.ContainsKey(nClosed))
            {
                LogService logService = __singleton<LogService>.instance();
                logService.logError(TAG, "com.core");
                return false;
            }
            ClosedMgr closedMgr = mClosedMgrs[nClosed];
            return closedMgr.checkClosed(nClosed);
        }

        public ClosedService()
        {
            mClosedMgrs = new Dictionary<int, ClosedMgr>();
            mClosed = new Dictionary<int, IClosed>();
        }

        static readonly string TAG = typeof(ClosedService).Name;
        Dictionary<int, ClosedMgr> mClosedMgrs;
        Dictionary<int, IClosed> mClosed;
    }
}
