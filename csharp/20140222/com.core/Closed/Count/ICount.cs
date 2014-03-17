using System.Collections.Generic;

namespace com.core
{
    public interface ICount
    {
        void runCount(int nClassify, int nOpened, IList<object> nOpeneds);

        string getCountName();
    }
}
