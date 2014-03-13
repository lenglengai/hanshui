using System;
using System.Collections.Generic;

namespace com.core
{
    public class Time : IIntStream
    {
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

        public void serialize(ISerialize nSerialize, int nCount)
        {
            nSerialize.runInt32(ref mId, "timeId", 0);
            nSerialize.runInt8(ref mType, "timeType", NORMALDAY);
            nSerialize.runStream(ref mTimeStart, "timeStart");
            nSerialize.runStream(ref mTimeCount, "timeCount");
            nSerialize.runStream(ref mTimeEnd, "timeEnd");
        }

        public bool checkClosed(DateTime nNowTime, DateTime nStartTime, DateTime nSaveTime)
        {
            if (OPEN == mType)
            {
                return false;
            }
            else if ( ( (NORMALDAY <= mType) && (NOWDAY >= mType) )
                || ( (YEAR <= mType) && (WEEK >= mType) ) )
            {
                DateTime startTime = this.getStartTime(nNowTime, nStartTime, nSaveTime);
                return mTimeCount.isDayClosed(nNowTime, nStartTime, mTimeEnd);
            }
            else if ((NOWHOUR == mType) || (DAY == mType))
            {
                DateTime startTime = this.getStartTime(nNowTime, nStartTime, nSaveTime);
                return mTimeCount.isHourClosed(nNowTime, nStartTime);
            }
            else if (NOWMIN == mType)
            {
                DateTime startTime = this.getStartTime(nNowTime, nStartTime, nSaveTime);
                return mTimeCount.isMinClosed(nNowTime, nStartTime);
            }
            else if (NOWSEC == mType)
            {
                DateTime startTime = this.getStartTime(nNowTime, nStartTime, nSaveTime);
                return mTimeCount.isSecClosed(nNowTime, nStartTime);
            }
            else
            {
                return true;
            }
        }

        DateTime getStartTime(DateTime nNowTime, DateTime nStartTime, DateTime nSaveTime)
        {
            if (NORMALDAY == mType)
            {
                return mTimeStart.getTime();
            }
            else if (STARTDAY == mType)
            {
                return nStartTime;
            }
            else if (NOWDAY == mType)
            {
                return nSaveTime;
            }
            else if (NOWHOUR == mType)
            {
                return nSaveTime;
            }
            else if (NOWMIN == mType)
            {
                return nSaveTime;
            }
            else if (NOWSEC == mType)
            {
                return nSaveTime;
            }
            else if (YEAR == mType)
            {
                return mTimeStart.getYearTime(nNowTime);
            }
            else if (MONTH == mType)
            {
                return mTimeStart.getMonthTime(nNowTime);
            }
            else if (WEEK == mType)
            {
                return mTimeStart.getWeekTime(nNowTime);
            }
            else if (DAY == mType)
            {
                return mTimeStart.getDayTime(nNowTime);
            }
            else
            {
                return DateTime.MinValue;
            }
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
            mTimeEnd = new TimeEnd();
        }

        int mId;
        sbyte mType;
        TimeStart mTimeStart;
        TimeCount mTimeCount;
        TimeEnd mTimeEnd;
    }
}
