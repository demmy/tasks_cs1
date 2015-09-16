using System.Collections.Generic;
using System.Linq;

namespace Collections.Sergey.Loger
{
    class MyLoger: ILoger
    {
        private readonly List<string> _logs;
        public List<string> Logs
        {
            get { return _logs; }
        }

        public MyLoger()
        {
            _logs = new List<string>();
        }
        public void Log(params object[] arrayToLog)
        {
            string message = arrayToLog.Aggregate("", (currentString, el) => currentString + (el.ToString() + ":"));
            Logs.Add(message);
        }
    }
}
