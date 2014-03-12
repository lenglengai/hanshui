using System;

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
        }

        public bool isDayClosed(DateTime nNowTime, DateTime nStartTime, TimeEnd nTimeEnd)
        {
            DateTime startTime = nStartTime.AddDays(mSpace);
            if (startTime > nNowTime) return true;
            DateTime endTime = new DateTime(startTime.Year, startTime.Month, startTime.Day, nTimeEnd.getHour(), nTimeEnd.getMin(), 0);
            endTime = endTime.AddDays(mSpace + (mCount + mNext) * mCycle);
            if (endTime < nNowTime) return true;
            TimeSpan timeSpan = nNowTime - startTime;
            int days = timeSpan.Days % (mCount + mNext);
            if (days < mCount)
            {
                return false;
            }
            else if (days == mCount)
            {
                if (nNowTime.Hour < nTimeEnd.getHour())
                {
                    return false;
                }
                else if (nNowTime.Hour == nTimeEnd.getHour())
                {
                    if (nNowTime.Minute <= nTimeEnd.getMin())
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        public bool isHourClosed(DateTime nNowTime, DateTime nStartTime)
        {
            DateTime startTime = nStartTime.AddHours(mSpace);
            if (startTime > nNowTime) return true;
            DateTime endTime = startTime.AddHours(mSpace + (mCount + mNext) * mCycle);
            if (endTime < nNowTime) return true;
            TimeSpan timeSpan = nNowTime - startTime;
            int hours = (int)(timeSpan.TotalHours % (mCount + mNext));
            if (hours <= mCount) return false;
            return true;
        }

        public bool isMinClosed(DateTime nNowTime, DateTime nStartTime)
        {
            DateTime startTime = nStartTime.AddMinutes(mSpace);
            if (startTime > nNowTime) return true;
            DateTime endTime = startTime.AddMinutes(mSpace + (mCount + mNext) * mCycle);
            if (endTime < nNowTime) return true;
            TimeSpan timeSpan = nNowTime - startTime;
            int hours = (int)(timeSpan.TotalMinutes % (mCount + mNext));
            if (hours <= mCount) return false;
            return true;
        }

        public bool isSecClosed(DateTime nNowTime, DateTime nStartTime)
        {
            DateTime startTime = nStartTime.AddSeconds(mSpace);
            if (startTime > nNowTime) return true;
            DateTime endTime = startTime.AddSeconds(mSpace + (mCount + mNext) * mCycle);
            if (endTime < nNowTime) return true;
            TimeSpan timeSpan = nNowTime - startTime;
            int hours = (int)(timeSpan.TotalSeconds % (mCount + mNext));
            if (hours <= mCount) return false;
            return true;
        }

        public TimeCount()
        {
            mSpace = 0;
            mCount = 0;
            mNext = 0;
            mCycle = 0;
        }

        short mSpace;
        short mCount;
        short mNext;
        short mCycle;
    }
}
