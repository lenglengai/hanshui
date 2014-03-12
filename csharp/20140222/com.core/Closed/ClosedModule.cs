using System.Collections.Generic;

namespace com.core
{
    public class ClosedModule : IHeadstream
    {
        public void headSerialize(ISerialize nSerialize)
        {
            nSerialize.runIntStreams(ref mClosedMgrs, "closedMgrs", "closedMgr");
            nSerialize.runCrc32(ref mId, "closedModuleId");
        }

        public string streamName()
        {
            return "closedModule";
        }

        public IDictionary<int, ClosedMgr> getClosedMgrs()
        {
            return mClosedMgrs;
        }

        public int getClosedModuleId()
        {
            return mId;
        }

        public ClosedModule()
        {
            mClosedMgrs = new Dictionary<int, ClosedMgr>();
            mId = default(int);
        }

        Dictionary<int, ClosedMgr> mClosedMgrs;
        int mId;
    }
}
