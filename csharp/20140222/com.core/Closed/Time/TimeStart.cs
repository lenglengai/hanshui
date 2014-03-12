using System;

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
            nSerialize.runInt8(ref mMin, "startMin", 0);
            nSerialize.runInt8(ref mWday, "startWday", 1);
        }

        public DateTime getWeekTime(DateTime nNowTime)
        {
            DateTime result = new DateTime(nNowTime.Year, nNowTime.Month, nNowTime.Day, mHour, mMin, 0);
            sbyte dayOfWeek = (sbyte)result.DayOfWeek;
            return result.AddDays(mWday - dayOfWeek);
        }

        public DateTime getDayTime(DateTime nNowTime)
        {
            return new DateTime(nNowTime.Year, nNowTime.Month, nNowTime.Day, mHour, mMin, 0);
        }

        public DateTime getMonthTime(DateTime nNowTime)
        {
            return new DateTime(nNowTime.Year, nNowTime.Month, mMday, mHour, mMin, 0);
        }

        public DateTime getYearTime(DateTime nNowTime)
        {
            return new DateTime(nNowTime.Year, mMonth, mMday, mHour, mMin, 0);
        }

        public DateTime getTime()
        {
            return new DateTime(mYear, mMonth, mMday, mHour, mMin, 0);
        }

        public TimeStart()
        {
            mYear = 2014;
            mMonth = 1;
            mMday = 1;
            mHour = 0;
            mMin = 0;
            mWday = 1;
        }

        short mYear;
        sbyte mMonth;
        sbyte mMday;
        sbyte mHour;
        sbyte mMin;
        sbyte mWday;
    }
}
