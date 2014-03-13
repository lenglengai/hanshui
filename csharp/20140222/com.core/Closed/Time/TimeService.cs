using System;
using System.Collections.Generic;

namespace com.core
{
    public class TimeService : IClosed
    {
        public bool checkClosed(int nClassify, int nClosed, IList<object> nCloseds)
        {
            if (!mTimeMgr.ContainsKey(nClassify)){
                LogService logService = __singleton<LogService>.instance();
                logService.logError(TAG, string.Format("checkClosed[{0}]", nClassify));
                return false;
            }
            TimeMgr timeMgr = mTimeMgr[nClassify];
            DateTime dateTime = DateTime.MinValue;
            if (nCloseds.Count > 0)
            {
                dateTime = (DateTime)nCloseds[0];
            }
            return timeMgr.checkClosed(getTime(), mStartTime, dateTime, nClosed);
        }

        public string getClosedName()
        {
            return TAG;
        }

        public void setTick(long nTick)
        {
            mTick = nTick;
        }

        public DateTime getTime()
        {
            return DateTime.Now.AddTicks(mTick);
        }

        public void setStartTime(long nTick)
        {
            mStartTime = new DateTime(nTick);
        }

        public DateTime getStartTime()
        {
            return mStartTime;
        }

        public TimeService()
        {
            mTimeMgr = new Dictionary<int, TimeMgr>();
            mStartTime = DateTime.MinValue;
            mTick = 0;
        }

        static readonly string TAG = typeof(TimeService).Name;
        Dictionary<int, TimeMgr> mTimeMgr;
        DateTime mStartTime;
        long mTick;
    }
}
