using System.Collections.Generic;

namespace com.core
{
    public class TimeService : IStream
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

        public TimeService()
        {
            mTimes = new Dictionary<int, Time>();
        }

        Dictionary<int, Time> mTimes;
    }
}
