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

        public IEnumerable<string> Dates()
        {
            foreach (var t in information)
            {
                yield return t.Item1.ToString();
            }
        }


        public IEnumerable<string> Information()
        {
            string result = " ";
            foreach (var t in information)
            {
                result = t.Item1.ToString() + " ";
                foreach (var i in t.Item2)
                {
                    result += " " + i.ToString();
                }
                yield return result;
            }
        }

        public string AllInformation()
        {
           return information.ToString();
        }

        public string IformationForDate(DateTime data, string disjunctive="\n\r" )
        {
            string result = " ";
            foreach (var t in information)
            {
                if (t.Item1.Day == data.Day && t.Item1.Month == data.Month && t.Item1.Year == data.Year)
                {
                    result += t.Item1.ToString() + " " ;
                    foreach (var i in t.Item2)
                    {
                        result += " " + i.ToString();
                    }
                    result +=  disjunctive;
                }
            }
            return result;
 
        }
        public string InformationBetweenDates(DateTime data1, DateTime data2, string disjunctive = "\n\r")
        {
            string result = " ";
            foreach (var t in information)
            {
                if (t.Item1>= data1 && t.Item1<=data2 )
                {
                    result += t.Item1.ToString() + " ";
                    foreach (var i in t.Item2)
                    {
                        result += " " + i.ToString();
                    }
                    result += disjunctive;
                }
            }
            return result;
        }

    }
}
