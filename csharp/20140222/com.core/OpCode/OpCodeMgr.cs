using System.Collections.Generic;

namespace com.core
{
    public class OpCodeMgr
    {
        public bool runRegister(int nOpCode)
        {
            if (mOpCodes.Contains(nOpCode)){
                return false;
            }
            mOpCodes.Add(nOpCode);
            return true;
        }

        public OpCodeMgr()
        {
            mOpCodes = new SortedSet<int>();
        }

        SortedSet<int> mOpCodes;
    }
}
