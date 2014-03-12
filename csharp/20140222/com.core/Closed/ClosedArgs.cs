using System.Collections.Generic;

namespace com.core
{
    public class ClosedArgs
    {
        public IList<object> getObjects()
        {
            return mObjects;
        }

        public int getClosedModuleId()
        {
            return mClosedModuleId;
        }

        public int getClosedMgrId()
        {
            return mClosedMgrId;
        }

        public ClosedArgs()
        {
            mObjects = new List<object>();
            mClosedModuleId = default(int);
            mClosedMgrId = default(int);
        }

        List<object> mObjects;
        int mClosedModuleId;
        int mClosedMgrId;
    }
}
