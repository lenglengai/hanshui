namespace com.core
{
    public class ErrorCode
    {
        public void setResult(bool nResult)
        {
            mResult = nResult;
        }

        public bool getResult()
        {
            return mResult;
        }

        public void setModule(int nModule)
        {
            mModule = nModule;
        }

        public int getModule()
        {
            return mModule;
        }

        public void setError(int nError)
        {
            mError = nError;
        }

        public int getError()
        {
            return mError;
        }

        public ErrorCode(bool nResult, int nModule, int nError)
        {
            mResult = nResult;
            mModule = nModule;
            mError = nError;
        }

        bool mResult;
        int mModule;
        int mError;
    }
}
