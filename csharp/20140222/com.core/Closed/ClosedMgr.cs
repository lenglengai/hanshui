using System.Collections.Generic;

namespace com.core
{
    public class ClosedMgr : IIntStream
    {
        public void serialize(ISerialize nSerialize, int nCount)
        {
            nSerialize.runStreamCount(ref mOpeneds, "openeds", "opened", 6);
            nSerialize.runStreamCount(ref mCloseds, "closeds", "closed", 6);
            nSerialize.runInt32(ref mId, "closedMgrId");
            nSerialize.runCrc32(ref mModule, "closedMgrModule");
            nSerialize.runCrc32(ref mError, "closedMgrError");
        }

        public int getKey()
        {
            return mId;
        }

        public IList<Opened> getOpeneds()
        {
            return mOpeneds;
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
            mCloseds = new List<Closed>();
            mOpeneds = new List<Opened>();
            mModule = ComCore.MODULE;
            mError = ComCore.SUCESS;
            mId = 0;
        }

        List<Closed> mCloseds;
        List<Opened> mOpeneds;
        int mModule;
        int mError;
        int mId;
    }
}
