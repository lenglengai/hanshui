using System.Collections.Generic;

namespace com.core
{
    public class ClosedMgr : IIntStream
    {
        public void serialize(ISerialize nSerialize)
        {
            nSerialize.runInt32(ref mId, "closedMgrId", 0);

            int index = 0, logic = 0, type = 0, id = 0, error = 0;
            nSerialize.runInt32(ref index, "closedIndex0", 0);
            nSerialize.runInt32(ref logic, "closedlogic0", 0);
            nSerialize.runInt32(ref type, "closedType0", 0);
            nSerialize.runInt32(ref id, "closedI0d", 0);
            nSerialize.runInt32(ref id, "closedError0", 0);
            this.addClosed(index, logic, type, id, error);

            index = 0; logic = 0; type = 0; id = 0; error = 0;
            nSerialize.runInt32(ref index, "closedIndex1", 0);
            nSerialize.runInt32(ref logic, "closedlogic1", 0);
            nSerialize.runInt32(ref type, "closedType1", 0);
            nSerialize.runInt32(ref id, "closedId1", 0);
            nSerialize.runInt32(ref id, "closedError1", 0);
            this.addClosed(index, logic, type, id, error);

            index = 0; logic = 0; type = 0; id = 0; error = 0;
            nSerialize.runInt32(ref index, "closedIndex2", 0);
            nSerialize.runInt32(ref logic, "closedlogic2", 0);
            nSerialize.runInt32(ref type, "closedType2", 0);
            nSerialize.runInt32(ref id, "closedId2", 0);
            nSerialize.runInt32(ref id, "closedError2", 0);
            this.addClosed(index, logic, type, id, error);

            index = 0; logic = 0; type = 0; id = 0; error = 0;
            nSerialize.runInt32(ref index, "closedIndex3", 0);
            nSerialize.runInt32(ref logic, "closedlogic3", 0);
            nSerialize.runInt32(ref type, "closedType3", 0);
            nSerialize.runInt32(ref id, "closedId3", 0);
            nSerialize.runInt32(ref id, "closedError3", 0);
            this.addClosed(index, logic, type, id, error);

            index = 0; logic = 0; type = 0; id = 0; error = 0;
            nSerialize.runInt32(ref index, "closedIndex4", 0);
            nSerialize.runInt32(ref logic, "closedlogic4", 0);
            nSerialize.runInt32(ref type, "closedTyp4", 0);
            nSerialize.runInt32(ref id, "closedId4", 0);
            nSerialize.runInt32(ref id, "closedError4", 0);
            this.addClosed(index, logic, type, id, error);

            index = 0; logic = 0; type = 0; id = 0; error = 0;
            nSerialize.runInt32(ref index, "closedIndex5", 0);
            nSerialize.runInt32(ref logic, "closedlogic5", 0);
            nSerialize.runInt32(ref type, "closedType5", 0);
            nSerialize.runInt32(ref id, "closedId5", 0);
            nSerialize.runInt32(ref id, "closedError5", 0);
            this.addClosed(index, logic, type, id, error);

            index = 0; logic = 0; type = 0; id = 0; error = 0;
            nSerialize.runInt32(ref index, "closedIndex6", 0);
            nSerialize.runInt32(ref logic, "closedlogic6", 0);
            nSerialize.runInt32(ref type, "closedType6", 0);
            nSerialize.runInt32(ref id, "closedId6", 0);
            nSerialize.runInt32(ref id, "closedError6", 0);
            this.addClosed(index, logic, type, id, error);
        }

        void addClosed(int nIndex, int nLogic, int nType, int nId, int nError)
        {
            if ((0 != nIndex) && (0 != nLogic) && (0 != nType) && (0 != nId))
            {
                Closed closed = new Closed(nLogic, nType, nId, nError);
                if (3 == nIndex)
                {
                    mCloseds3.Add(closed);
                }
                else if (2 == nIndex)
                {
                    mCloseds2.Add(closed);
                }
                else
                {
                    mCloseds1.Add(closed);
                }
            }
        }

        public bool checkClosed(int nClosed)
        {
            return false;
        }

        public int getKey()
        {
            return mId;
        }

        public ClosedMgr()
        {
            mId = 0;
            mCloseds1 = new List<Closed>();
            mCloseds2 = new List<Closed>();
            mCloseds3 = new List<Closed>();
        }

        int mId;
        List<Closed> mCloseds1;
        List<Closed> mCloseds2;
        List<Closed> mCloseds3;
    }
}
