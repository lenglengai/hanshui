namespace com.core
{
    public class TimeStart : IStream
    {
        public void serialize(ISerialize nSerialize)
        {
            nSerialize.runInt16(ref mYear, "startYear", 2014);
            nSerialize.runInt8(ref mMonth, "startMonth", 1);
            nSerialize.runInt8(ref mMday, "startMday", 1);
            nSerialize.runInt8(ref mHour, "startHour", 0);
            nSerialize.runInt8(ref mWday, "startWday", 1);
        }
        
        public TimeStart()
        {
            mYear = 2014;
            mMonth = 1;
            mMday = 1;
            mHour = 0;
            mWday = 1;
        }

        short mYear;
        sbyte mMonth;
        sbyte mMday;
        sbyte mHour;
        sbyte mWday;
    }
}
