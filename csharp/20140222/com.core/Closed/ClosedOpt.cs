
namespace com.core
{
    public class ClosedOpt : IStream
    {
        public void serialize(ISerialize nSerialize)
        {
            nSerialize.runInt16(ref mStart, "start");
            nSerialize.runInt16(ref mStart, "start");
            nSerialize.runInt16(ref mStart, "start");
        }

        short mStart;
        short mCount;
        short mCycle;
        short mSpace;
    }
}
