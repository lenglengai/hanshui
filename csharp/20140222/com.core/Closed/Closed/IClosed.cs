using System.Collections.Generic;

namespace com.core
{
    public interface IClosed
    {
        bool checkClosed(int nClassify, int nClosed, IList<object> nCloseds);

        string getClosedName();
    }
}
