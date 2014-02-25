using System;

namespace com.core
{
    public class Time : IIntStream
    {
        public const sbyte BEFORE = 2;

        public const sbyte OPEN = 0;
        public const sbyte CLOSED = 1;
        public const sbyte NORMALDAY = 2;
        public const sbyte STARTDAY = 3;
        public const sbyte NOWDAY = 4;
        public const sbyte NOWHOUR = 5;
        public const sbyte NOWMIN = 6;
        public const sbyte NOWSEC = 7;
        public const sbyte YEAR = 8;
        public const sbyte MONTH = 9;
        public const sbyte WEEK = 10;
        public const sbyte DAY = 11;

        public void serialize(ISerialize nSerialize)
        {
            nSerialize.runInt32(ref mId, "timeId", 0);
            nSerialize.runInt8(ref mType, "timeType", NORMALDAY);
            nSerialize.runStream(ref mTimeStart, "timeStart");
            nSerialize.runStream(ref mTimeCount, "timeCount");
        }

        public int getKey()
        {
            return mId;
        }

        public int getId()
        {
            return mId;
        }

        public Time()
        {
            mId = 0;
            mType = NORMALDAY;
            mTimeStart = new TimeStart();
            mTimeCount = new TimeCount();
        }

        int mId;
        sbyte mType;
        TimeStart mTimeStart;
        TimeCount mTimeCount;
    }
}
