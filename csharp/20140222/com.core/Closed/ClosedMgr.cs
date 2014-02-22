using System.Collections.Generic;

namespace com.core
{
    public class ClosedMgr : IHeadstream
    {
        public void headSerialize(ISerialize nSerialize)
        {
            nSerialize.runIntStreams(ref mCloseds, "closedMgr", "closed");
            nSerialize.runInt32(ref mType, "type");
        }

        public string streamName()
        {
            return "closedMgr";
        }

        public ClosedMgr()
        {
            mCloseds = new Dictionary<int, Closed>();
        }

        Dictionary<int, Closed> mCloseds;
        int mType;
    }
}
