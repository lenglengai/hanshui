using System;

namespace com.core
{
    public class Closed : IIntStream
    {
        public void serialize(ISerialize nSerialize)
        {
            nSerialize.runDateTime(ref mStartTime, "startTime");
            nSerialize.runInt32(ref mId, "id");
        }

        public int getKey()
        {
            return mId;
        }

        public DateTime getStartTime()
        {
            return mStartTime;
        }

        public int getId()
        {
            return mId;
        }

        public Closed()
        {
            mStartTime = default(DateTime);
            mId = default(int);
        }

        DateTime mStartTime;
        int mId;
    }
}
