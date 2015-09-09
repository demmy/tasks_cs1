using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Sergey.Loger
{
    interface ILoger
    {
        void Log(params object[] arrayToLog);
    }
}
