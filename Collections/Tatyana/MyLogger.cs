using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Tatyana
{
    class MyLogger: ILogger
    {
        //Dictionary<DateTime, List<object>> information = new Dictionary<DateTime, List<object>>();

        //public void Log(params object[] listToLog)
        //{
        //    DateTime t = DateTime.Now;
        //    information[t] = new List<object>();
        //    for (int i = 0; i < listToLog.Length; i++)
        //    {
        //        information[t].Add(listToLog[i]);
        //    }
        //}

        List<Tuple<DateTime, List<object>>> information = new List<Tuple<DateTime, List<object>>>();
       
        public void Log(params object[] listToLog)
        {
            DateTime t = DateTime.Now;
            List<object> inf =new List<object>();
            
            for (int i = 0; i < listToLog.Length; i++)
            {
                inf.Add(listToLog[i]);
            }
            Tuple<DateTime, List<object>> a= new Tuple<DateTime,List<object>>(t,inf);
            information.Add(a);
        }
    }
}
