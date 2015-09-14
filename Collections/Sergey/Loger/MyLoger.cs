using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Sergey.Loger
{
    class MyLoger: ILoger
    {
        public List<string> Logs { get; private set; }

        public MyLoger()
        {
            Logs = new List<string>();
        }
        public void Log(params object[] arrayToLog)
        {
            string message = arrayToLog.Aggregate("", (currentString, el) => currentString + (el.ToString() + ":"));
            Logs.Add(message);
        }
    }
}
