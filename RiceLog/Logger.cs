using System;

namespace RiceLog
{
    public class Logger
    {
        public static VERBOSITY CurrentVerbosity = VERBOSITY.INFO;

        private Logger() { }

        public enum VERBOSITY
        {
            NONE = 0,
            ERROR = 1,
            WARN = 2,
            INFO = 3
        }

        public static void Log(String message, VERBOSITY verbosity)
        {
            if (verbosity <= CurrentVerbosity)
            {
                string verbosityName = Enum.GetName(typeof(VERBOSITY), verbosity);
                Console.WriteLine($"[{verbosityName}] {message}");
            }
        }

        public static void Log(String message)
        {
            Log(message, VERBOSITY.INFO);
        }
    }
}
