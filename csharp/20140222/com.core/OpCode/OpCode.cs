namespace com.core
{
    public class OpCode
    {
        public const int SUCESS = 0;
        public const int HAVEUPDATE = 1;
        public const int MUSTUPDATE = 2;

        public static void runPreinit()
        {
            OpCodeMgr opCodeMgr = __singleton<OpCodeMgr>.instance();
            if (!opCodeMgr.runRegister(ID)) {
                LogService logService = __singleton<LogService>.instance();
                logService._logFatal(TAG, "com.core");
            }
        }
        public static readonly int ID = GenerateId.runCommon("com.core");
        static readonly string TAG = typeof(OpCode).Name;
    }
}
