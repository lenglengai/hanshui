using System.Collections.Generic;

namespace com.core
{
    public class ClosedService
    {
        public ErrorCode runClosed(ClosedArgs nClosedArgs)
        {
            int closedModuleId = nClosedArgs.getClosedModuleId();
            if (!mClosedModules.ContainsKey(closedModuleId))
            {
                LogService logService = __singleton<LogService>.instance();
                logService.logError(TAG, string.Format("ClosedArgs[{0}]", closedModuleId));
                return new ErrorCode(true, ComCore.MODULE, ComCore.SYSTEM);
            }
            ClosedModule closedModule = mClosedModules[closedModuleId];
            return this.runClosed(closedModule, nClosedArgs);
        }

        ErrorCode runClosed(ClosedModule nClosedModule, ClosedArgs nClosedArgs)
        {
            IDictionary<int, ClosedMgr> closedMgrs = nClosedModule.getClosedMgrs();
            int closedMgrId = nClosedArgs.getClosedMgrId();
            if (!closedMgrs.ContainsKey(closedMgrId))
            {
                LogService logService = __singleton<LogService>.instance();
                logService.logError(TAG, string.Format("ClosedModule[{0}]", closedMgrId));
                return new ErrorCode(true, ComCore.MODULE, ComCore.SYSTEM);
            }
            return runClosed(closedMgrs[closedMgrId], nClosedArgs);
        }

        ErrorCode runClosed(ClosedMgr nClosedMgr, ClosedArgs nClosedArgs)
        {
            bool isOpened = false;
            int module = nClosedMgr.getModule();
            int error_ = nClosedMgr.getError();
            IList<Closed> closeds = nClosedMgr.getCloseds();
            foreach (Closed i in closeds)
            {
                if (!this.checkClosed(i, nClosedArgs))
                {
                    isOpened = false;
                    module = i.getModule();
                    error_ = i.getError();
                    break;
                }
            }
            if (isOpened) {
                IList<Opened> openeds = nClosedMgr.getOpeneds();
                foreach (Opened i in openeds)
                {
                    this.runOpened(i, nClosedArgs);
                }
            }
            return new ErrorCode(isOpened, module, error_);
        }

        void runOpened(Opened nOpened, ClosedArgs nClosedArgs)
        {
            List<object> closeds = new List<object>();
            IList<int> ints = nOpened.getObjects();
            IList<object> objects = nClosedArgs.getObjects();
            foreach (int i in ints)
            {
                object temp = objects[i];
                closeds.Add(temp);
            }
            int type = nOpened.getType();
            if (!mOpeneds.ContainsKey(type))
            {
                LogService logService = __singleton<LogService>.instance();
                logService.logError(TAG, string.Format("nOpened[{0}]", type));
                return;
            }
            IOpened opened = mOpeneds[type];
            int clossify = nOpened.getClassify();
            int classedId = nOpened.getId();
            opened.runOpen(clossify, classedId, closeds);
        }

        bool checkClosed(Closed nClosed, ClosedArgs nClosedArgs)
        {
            List<object> closeds = new List<object>();
            IList<int> ints = nClosed.getObjects();
            IList<object> objects = nClosedArgs.getObjects();
            foreach (int i in ints)
            {
                object temp = objects[i];
                closeds.Add(temp);
            }
            int type = nClosed.getType();
            if (!mCloseds.ContainsKey(type))
            {
                LogService logService = __singleton<LogService>.instance();
                logService.logError(TAG, string.Format("nClosed[{0}]", type));
                return false;
            }
            IClosed closed = mCloseds[type];
            int clossify = nClosed.getClassify();
            int classedId = nClosed.getId();
            return closed.checkClosed(clossify, classedId, closeds);
        }

        public ClosedService()
        {
            mClosedModules = new Dictionary<int, ClosedModule>();
            mCloseds = new Dictionary<int, IClosed>();
            mOpeneds = new Dictionary<int, IOpened>();
        }

        static readonly string TAG = typeof(ClosedService).Name;
        Dictionary<int, ClosedModule> mClosedModules;
        Dictionary<int, IClosed> mCloseds;
        Dictionary<int, IOpened> mOpeneds;
    }
}
