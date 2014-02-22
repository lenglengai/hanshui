namespace com.core
{
    public class __singleton<T> where T : new()
    {
        public static T instance()
        {
            if (null == mT) 
            {
                mT = new T();
            }
            return mT;
        }

        static T mT = default(T);
    }
}
