namespace com.core
{
    public class ComCore
    {
        public const int NONE = 0;
        public const int SUCESS = 1;
        public const int HAVEUPDATE = 2;
        public const int MUSTUPDATE = 3;
        public const int SYSTEM = 4;

        public static void runPreinit()
        {
            OpCodeMgr opCodeMgr = __singleton<OpCodeMgr>.instance();
            if (!opCodeMgr.runRegister(MODULE))
            {
                LogService logService = __singleton<LogService>.instance();
                logService.logFatal(TAG, string.Format("runPreinit[{0}]", MODULE));
            }
        }

        public static readonly int MODULE = GenerateId.runCommon("com.core");
        static readonly string TAG = typeof(ComCore).Name;
    }
}
