using System.Collections.Generic;

namespace com.core
{
    public class TimeService : IStream, IClosed
    {
        public void serialize(ISerialize nSerialize)
        {
            nSerialize.runIntStreams(ref mTimes, "times", "time");
        }

        public void runPreinit()
        {
            XmlReader xmlReader = new XmlReader();
            xmlReader.openUrl("config/time.xml");
            this.serialize(xmlReader);
            xmlReader.runClose();
        }

        public string getName()
        {
            return TAG;
        }

        public TimeService()
        {
            mTimes = new Dictionary<int, Time>();
        }

        static readonly string TAG = typeof(ClosedService).Name;
        Dictionary<int, Time> mTimes;
    }
}
