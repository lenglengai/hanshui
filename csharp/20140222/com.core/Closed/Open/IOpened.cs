using System.Collections.Generic;

namespace com.core
{
    public interface IOpened
    {
        void runOpen(int nClassify, int nOpened, IList<object> nOpeneds);

        string getOpenName();
    }
}
