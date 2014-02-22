namespace com.core
{
    public class __tuple<T0>
    {
        public T0 get_0()
        {
            return mT0;
        }

        public __tuple(T0 nT0)
        {
            mT0 = nT0;
        }

        T0 mT0;
    }

    public class __tuple<T0, T1> : __tuple<T0>
    {
        public T1 get_1()
        {
            return mT1;
        }

        public __tuple(T0 nT0, T1 nT1)
            : base(nT0)
        {
            mT1 = nT1;
        }

        T1 mT1;

    }

    public class __tuple<T0, T1, T2> : __tuple<T0, T1>
    {
        public T2 get_2()
        {
            return mT2;
        }

        public __tuple(T0 nT0, T1 nT1, T2 nT2)
            : base(nT0, nT1)
        {
            mT2 = nT2;
        }

        T2 mT2;
    }

    public class __tuple<T0, T1, T2, T3> : __tuple<T0, T1, T2>
    {
        public T3 get_3()
        {
            return mT3;
        }

        public __tuple(T0 nT0, T1 nT1, T2 nT2, T3 nT3)
            : base(nT0, nT1, nT2)
        {
            mT3 = nT3;
        }

        T3 mT3;
    }

    public class __tuple<T0, T1, T2, T3, T4> : __tuple<T0, T1, T2, T3>
    {
        public T4 get_4()
        {
            return mT4;
        }

        public __tuple(T0 nT0, T1 nT1, T2 nT2, T3 nT3, T4 nT4)
            : base(nT0, nT1, nT2, nT3)
        {
            mT4 = nT4;
        }

        T4 mT4;
    }

    public class __tuple<T0, T1, T2, T3, T4, T5> : __tuple<T0, T1, T2, T3, T4>
    {
        public T5 get_5()
        {
            return mT5;
        }

        public __tuple(T0 nT0, T1 nT1, T2 nT2, T3 nT3, T4 nT4, T5 nT5)
            : base(nT0, nT1, nT2, nT3, nT4)
        {
            mT5 = nT5;
        }

        T5 mT5;
    }

    public class __tuple<T0, T1, T2, T3, T4, T5, T6> : __tuple<T0, T1, T2, T3, T4, T5>
    {
        public T6 get_6()
        {
            return mT6;
        }

        public __tuple(T0 nT0, T1 nT1, T2 nT2, T3 nT3, T4 nT4, T5 nT5, T6 nT6)
            : base(nT0, nT1, nT2, nT3, nT4, nT5)
        {
            mT6 = nT6;
        }

        T6 mT6;
    }

    public class __tuple<T0, T1, T2, T3, T4, T5, T6, T7> : __tuple<T0, T1, T2, T3, T4, T5, T6>
    {
        public T7 get_7()
        {
            return mT7;
        }

        public __tuple(T0 nT0, T1 nT1, T2 nT2, T3 nT3, T4 nT4, T5 nT5, T6 nT6, T7 nT7)
            : base(nT0, nT1, nT2, nT3, nT4, nT5, nT6)
        {
            mT7 = nT7;
        }

        T7 mT7;
    }

    public class __tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8> : __tuple<T0, T1, T2, T3, T4, T5, T6, T7>
    {
        public T8 get_8()
        {
            return mT8;
        }

        public __tuple(T0 nT0, T1 nT1, T2 nT2, T3 nT3, T4 nT4, T5 nT5, T6 nT6, T7 nT7, T8 nT8)
            : base(nT0, nT1, nT2, nT3, nT4, nT5, nT6, nT7)
        {
            mT8 = nT8;
        }

        T8 mT8;
    }

    public class __tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : __tuple<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    {
        public T9 get_9()
        {
            return mT9;
        }

        public __tuple(T0 nT0, T1 nT1, T2 nT2, T3 nT3, T4 nT4, T5 nT5, T6 nT6, T7 nT7, T8 nT8, T9 nT9)
            : base(nT0, nT1, nT2, nT3, nT4, nT5, nT6, nT7, nT8)
        {
            mT9 = nT9;
        }
        
        T9 mT9;
    }
}
