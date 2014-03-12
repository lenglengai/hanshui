using System;
using System.Collections.Generic;

namespace com.core
{
    public class Closed : IStream
    {
        public void serialize(ISerialize nSerialize, int nCount)
        {
            nSerialize.runInt32Semi(ref mObjects, "closedObjects_" + nCount);
            nSerialize.runCrc32(ref mClassify, "closedClassify_" + nCount);
            nSerialize.runInt32(ref mType, "closedType_" + nCount);
            nSerialize.runInt32(ref mId, "closedId_" + nCount);
            nSerialize.runCrc32(ref mModule, "closedModule_" + nCount);
            nSerialize.runCrc32(ref mError, "closedError_" + nCount);
        }
        
        public IList<int> getObjects()
        {
            return mObjects;
        }

        public int getClassify()
        {
            return mClassify;
        }

        public int getType()
        {
            return mType;
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

        public Closed()
        {
            mObjects = new List<int>();
            mClassify = default(int);
            mType = default(int);
            mId = default(int);
            mModule = default(int);
            mError = default(int);
        }

        List<int> mObjects;
        int mClassify;
        int mType;
        int mId;
        int mModule;
        int mError;
    }
}
