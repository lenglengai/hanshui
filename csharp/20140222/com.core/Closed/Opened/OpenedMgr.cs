using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.core
{
    public class OpenedMgr : IIntStream
    {
        public void serialize(ISerialize nSerialize)
        {
        }

        public int getKey()
        {
        }

        public OpenedMgr()
        {
            mId = 0;
            mModule = ComCore.MODULE;
            mError = ComCore.SUCESS;
            mOpeneds = new List<Opened>();
        }

        int mId;
        int mModule;
        int mError;
        List<Opened> mOpeneds;
    }
}
