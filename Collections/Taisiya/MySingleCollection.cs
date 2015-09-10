using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


namespace Collections.Taisiya
{
    class MySingleCollection<T> : Collection<T>
    {
        ILogger Logger;
        int Count;

        public MySingleCollection(ILogger logger)
        {
            Logger = logger;
            Count++;
        }


        protected override void ClearItems()
        {
            Logger.Log(Count + " elements in collection. Clearing of items in collection");
            base.ClearItems();
        }

        protected override void InsertItem(int index, T item)
        {
            Logger.Log(Count + " elements in collection. Insert of item " + item + " with index " + index + " in collection." + Count + " elements in collection.");
            base.InsertItem(index, item);
        }

        protected override void RemoveItem(int index)
        {
            Logger.Log(Count + " elements in collection. Remove of new item with index " + index + " from collection." + Count + " elements in collection.");
            base.RemoveItem(index);
        }

        protected override void SetItem(int index, T item)
        {
            Logger.Log("Setting of item " + item + " with index " + index + " in collection");
            base.SetItem(index, item);
        }
    }

    interface ILogger
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
