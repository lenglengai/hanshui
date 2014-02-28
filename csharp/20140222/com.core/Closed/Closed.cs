namespace com.core
{
    public class Closed
    {
        public const int AND = 1;
        public const int OR = 2;

        public const int TIME = 1;

        public bool checkClosed()
        {
            return false;
        }

        public bool checkClosed(bool nValue)
        {
            return false;
        }

        public Closed(int nLogic, int nType, int nId, int nError)
        {
            mLogic = nLogic;
            mType = nType;
            mId = nId;
            mError = nError;
        }

        int mLogic;
        int mType;
        int mId;
        int mError;
    }
}
