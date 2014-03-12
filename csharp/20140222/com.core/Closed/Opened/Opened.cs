using System;
using System.Collections.Generic;

namespace com.core
{
    public class Opened : IStream
    {
        public void serialize(ISerialize nSerialize, int nCount)
        {
            nSerialize.runCrc32(ref mClassify, "classify_" + nCount);
            nSerialize.runInt32(ref mType, "type_" + nCount);
            nSerialize.runInt32(ref mId, "id_" + nCount);
            nSerialize.runInt32Semi(ref mObjects, "objects_" + nCount);
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

        public Opened()
        {
            mObjects = new List<int>();
            mClassify = default(int);
            mType = default(int);
            mId = default(int);
        }

        List<int> mObjects;
        int mClassify;
        int mType;
        int mId;
    }
}
