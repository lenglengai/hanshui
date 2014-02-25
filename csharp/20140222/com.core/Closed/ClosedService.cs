using System.Collections.Generic;

namespace com.core
{
    public class ClosedService : IStream
    {
        public void serialize(ISerialize nSerialize)
        {
            nSerialize.runIntStreams(ref mClosedMgrs, "closeds", "closed");
        }

        public int checkClosed(int nClosed)
        {
            if (!mClosedMgrs.ContainsKey(nClosed))
            {
                LogService logService = __singleton<LogService>.instance();
                logService.logError(TAG, "com.core");
                return OpCode.SYSTEM;
            }
            ClosedMgr closedMgr = mClosedMgrs[nClosed];
            return closedMgr.checkClosed(nClosed);
        }

        public void runPreinit()
        {
            XmlReader xmlReader = new XmlReader();
            xmlReader.openUrl("config/closed.xml");
            this.serialize(xmlReader);
            xmlReader.runClose();
        }

        public ClosedService()
        {
            mClosedMgrs = new Dictionary<int, ClosedMgr>();
        }

        static readonly string TAG = typeof(ClosedService).Name;
        Dictionary<int, ClosedMgr> mClosedMgrs;
    }
}
