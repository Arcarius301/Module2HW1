using System;
using System.Text;

namespace Module2HW1
{
    public sealed class Logger
    {
        private StringBuilder _buffer = new StringBuilder();
        private static readonly Logger _instance = new Logger();
        static Logger()
        {
        }

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                return _instance;
            }
        }

        public void LogInformation(EventLevel level, string message)
        {
            string stringBuffer = $"{DateTime.Now}: {level}: {message}";
            _buffer.AppendLine(stringBuffer);
            Console.WriteLine(stringBuffer);
        }

        public string GetLog()
        {
            return _buffer.ToString();
        }
    }
}
