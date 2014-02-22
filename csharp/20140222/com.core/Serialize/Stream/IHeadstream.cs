namespace com.core
{
    public interface IHeadstream
    {
        void headSerialize(ISerialize nSerialize);

        string streamName();
    }
}
