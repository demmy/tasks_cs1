using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Collections.Taisiya
{
 class MySingleCollection<T> : Collection<T>
    {
        ILogger Logger;
        int count;

        public MySingleCollection(ILogger logger)
        {
            Logger = logger;
            count++;
        }


        protected override void ClearItems()
        {
            Logger.Log(count + " elements in collection. Clearing of items in collection");
            base.ClearItems();
        }

        protected override void InsertItem(int index, T item)
        {
            Logger.Log(count + " elements in collection. Insert of item " + item + " with index " + index + " in collection." + count + " elements in collection." );
            base.InsertItem(index, item);
        }

        protected override void RemoveItem(int index)
        {
            Logger.Log(count + " elements in collection. Remove of new item with index " + index + " from collection." + count + " elements in collection." );
            base.RemoveItem(index);
        }

        protected override void SetItem(int index, T item)
        {
            Logger.Log("Setting of item " + item + " with index " + index + " in collection");
            base.SetItem(index, item);

        }

    }

    interface  ILogger
    {
        void Log(params object[] listToLog);
    }


    class MyLogger : ILogger
    {      
        public void Log(params object[] listToLog)
        {
            DateTime CurrentTime = DateTime.Now;

            for (int i = 0; i < listToLog.Length; i++)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"log.txt", true))
                {
                    string LoggedStringMessage = String.Format("{0:yyMMdd hh:mm:ss} {1}", CurrentTime, listToLog[i]);
                    file.WriteLine(LoggedStringMessage);
                    file.Close();
                }
            }

        }
        
    }
}