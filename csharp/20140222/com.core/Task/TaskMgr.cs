using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.core
{
    public class TaskMgr
    {
        public void acceptTask(uint nTaskId)
        {

        }

        public void cancelTask(uint nTaskId)
        {

        }

        public void finishTask(uint nTaskId)
        {

        }

        public void _runActionId(ActionId nActionId)
        {
            foreach (KeyValuePair<uint, Task> i in mTasks)
            {
                i.Value._runActionId(nActionId);
            }
        }

        public TaskMgr()
        {
            mTasks = new Dictionary<int, Task>();
        }

        Dictionary<int, Task> mTasks;
    }
}
