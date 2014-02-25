namespace com.core
{
    public class TimeCount : IStream
    {
        public void serialize(ISerialize nSerialize)
        {
            nSerialize.runInt16(ref mSpace, "countSpace");
            nSerialize.runInt16(ref mCount, "countCount");
            nSerialize.runInt16(ref mNext, "countNext");
            nSerialize.runInt16(ref mCycle, "countCycle");
            nSerialize.runInt8(ref mEnd, "countEnd");
        }

        public TimeCount()
        {
            mSpace = 0;
            mCount = 0;
            mNext = 0;
            mCycle = 0;
            mEnd = 0;
        }

        short mSpace;
        short mCount;
        short mNext;
        short mCycle;
        sbyte mEnd;
    }
}
