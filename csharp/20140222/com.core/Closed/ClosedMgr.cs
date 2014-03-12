using System.Collections.Generic;

namespace com.core
{
    public class ClosedMgr : IIntStream
    {
        public void serialize(ISerialize nSerialize)
        {
            nSerialize.runStreamCount(ref mCloseds, "closeds", "closed", 3);
            nSerialize.runInt32(ref mId, "closedMgrId");
            nSerialize.runCrc32(ref mModule, "closedMgrModule");
            nSerialize.runCrc32(ref mError, "closedMgrError");
        }

        public int getKey()
        {
            return mId;
        }

        public IList<Closed> getCloseds()
        {
            return mCloseds;
        }

        public int getId()
        {
            return mId;
        }

        public int getModule()
        {
            return mModule;
        }

        public int getError()
        {
            return mError;
        }

        public ClosedMgr()
        {
            mId = 0;
            mModule = ComCore.MODULE;
            mError = ComCore.SUCESS;
            mCloseds = new List<Closed>();
        }

        int mId;
        int mModule;
        int mError;
        List<Closed> mCloseds;
    }
}
