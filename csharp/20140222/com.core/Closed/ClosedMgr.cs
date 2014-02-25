using System.Collections.Generic;

namespace com.core
{
    public class ClosedMgr : IIntStream
    {
        public void serialize(ISerialize nSerialize)
        {
            nSerialize.runInt32(ref mId, "closedMgrId", 0);

            int type = 0; int id = 0;
            nSerialize.runInt32(ref type, "closedType0", 0);
            nSerialize.runInt32(ref id, "closedI0d", 0);
            if ((0 != type) && (0 != id))
            {
                Closed closed = new Closed(type, id);
                mCloseds.Add(closed);
            }

            type = 0; id = 0;
            nSerialize.runInt32(ref type, "closedType1", 0);
            nSerialize.runInt32(ref id, "closedId1", 0);
            if ((0 != type) && (0 != id))
            {
                Closed closed = new Closed(type, id);
                mCloseds.Add(closed);
            }
            type = 0; id = 0;
            nSerialize.runInt32(ref type, "closedType2", 0);
            nSerialize.runInt32(ref id, "closedId2", 0);
            if ((0 != type) && (0 != id))
            {
                Closed closed = new Closed(type, id);
                mCloseds.Add(closed);
            }
            type = 0; id = 0;
            nSerialize.runInt32(ref type, "closedType3", 0);
            nSerialize.runInt32(ref id, "closedId3", 0);
            if ((0 != type) && (0 != id))
            {
                Closed closed = new Closed(type, id);
                mCloseds.Add(closed);
            }

            type = 0; id = 0;
            nSerialize.runInt32(ref type, "closedTyp4", 0);
            nSerialize.runInt32(ref id, "closedId4", 0);
            if ((0 != type) && (0 != id))
            {
                Closed closed = new Closed(type, id);
                mCloseds.Add(closed);
            }

            type = 0; id = 0;
            nSerialize.runInt32(ref type, "closedType5", 0);
            nSerialize.runInt32(ref id, "closedId5", 0);
            if ((0 != type) && (0 != id))
            {
                Closed closed = new Closed(type, id);
                mCloseds.Add(closed);
            }

            type = 0; id = 0;
            nSerialize.runInt32(ref type, "closedType6", 0);
            nSerialize.runInt32(ref id, "closedId6", 0);
            if ((0 != type) && (0 != id))
            {
                Closed closed = new Closed(type, id);
                mCloseds.Add(closed);
            }

            type = 0; id = 0;
            nSerialize.runInt32(ref type, "closedType7", 0);
            nSerialize.runInt32(ref id, "closedId7", 0);
            if ((0 != type) && (0 != id))
            {
                Closed closed = new Closed(type, id);
                mCloseds.Add(closed);
            }

            type = 0; id = 0;
            nSerialize.runInt32(ref type, "closedType8", 0);
            nSerialize.runInt32(ref id, "closedId8", 0);
            if ((0 != type) && (0 != id))
            {
                Closed closed = new Closed(type, id);
                mCloseds.Add(closed);
            }

            type = 0; id = 0;
            nSerialize.runInt32(ref type, "closedType9", 0);
            nSerialize.runInt32(ref id, "closedId9", 0);
            if ((0 != type) && (0 != id))
            {
                Closed closed = new Closed(type, id);
                mCloseds.Add(closed);
            }
        }

        public int checkClosed(int nClosed)
        {

        }

        public int getKey()
        {
            return mId;
        }

        public ClosedMgr()
        {
            mId = 0;
            mCloseds = new List<Closed>();
        }

        int mId;
        List<Closed> mCloseds;
    }
}
