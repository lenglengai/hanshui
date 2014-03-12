using System.Collections.Generic;

namespace com.core
{
    public class ClosedService
    {
        public void runPlugin(string nUrl)
        {
            XmlReader xmlReader = new XmlReader();
            xmlReader.openUrl("config/closed.xml");
            this.serialize(xmlReader);
            xmlReader.runClose();
        }

        public OpCode checkClosed(ClosedArgs nClosedArgs)
        {
            int closedModuleId = nClosedArgs.getClosedModuleId();
            if (!mClosedModules.ContainsKey(closedModuleId))
            {
                LogService logService = __singleton<LogService>.instance();
                logService.logError(TAG, string.Format("ClosedArgs[{0}]", closedModuleId));
                return new OpCode(true, ComCore.MODULE, ComCore.SYSTEM);
            }
            ClosedModule closedModule = mClosedModules[closedModuleId];
            return this.checkClosed(closedModule, nClosedArgs);
        }

        OpCode checkClosed(ClosedModule nClosedModule, ClosedArgs nClosedArgs)
        {
            IDictionary<int, ClosedMgr> closedMgrs = nClosedModule.getClosedMgrs();
            int closedMgrId = nClosedArgs.getClosedMgrId();
            if (!closedMgrs.ContainsKey(closedMgrId))
            {
                LogService logService = __singleton<LogService>.instance();
                logService.logError(TAG, string.Format("ClosedModule[{0}]", closedMgrId));
                return new OpCode(true, ComCore.MODULE, ComCore.SYSTEM);
            }
            return checkClosed(closedMgrs[closedMgrId], nClosedArgs);
        }

        OpCode checkClosed(ClosedMgr nClosedMgr, ClosedArgs nClosedArgs)
        {
            int module = nClosedMgr.getModule();
            int error_ = nClosedMgr.getError();
            OpCode result = new OpCode(true, module, error_);
            IList<Closed> closeds = nClosedMgr.getCloseds();
            foreach (Closed i in closeds)
            {
                if (!this.checkClosed(i, nClosedArgs))
                {
                    module = nClosedMgr.getModule();
                    error_ = nClosedMgr.getError();
                    result.setResult(false);
                    result.setModule(module);
                    result.setError(error_);
                    break;
                }
            }
            return result;
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
        }

        static readonly string TAG = typeof(ClosedService).Name;
        Dictionary<int, ClosedModule> mClosedModules;
        Dictionary<int, IClosed> mCloseds;
    }
}
