namespace com.core
{
    public class TimeEnd : IStream
    {
        public void serialize(ISerialize nSerialize)
        {
            nSerialize.runInt8(ref mHour, "endHour");
            nSerialize.runInt8(ref mMin, "endHour");
        }

        public sbyte getHour()
        {
            return mHour;
        }

        public sbyte getMin()
        {
            return mMin;
        }

        public TimeEnd()
        {
            mHour = 0;
            mMin = 0;
        }

        sbyte mHour;
        sbyte mMin;
    }
}
