using System.Collections.Generic;

namespace com.core
{
    public class ClosedService
    {
        public void runPreinit()
        {

        }

        public ClosedService()
        {
            mClosedMgr = new Dictionary<int, ClosedMgr>();
        }

        Dictionary<int, ClosedMgr> mClosedMgr;
    }
}
