using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Nikita
{
    class MySingleCollection<T> : Collection<T>
    {
        private readonly MyLogger _logger;
        public MySingleCollection(MyLogger logger)
        {
            _logger = logger;
        }

        protected override void ClearItems()
        {
            _logger.Log("Clearing items below");
            _logger.Log(Items.ToArray());
            base.ClearItems();
        }

        protected override void InsertItem(int index, T item)
        {
            _logger.Log(string.Format("Item {0} was inserted to {1} index", item.ToString(), index));
            _logger.Log(item);
            base.InsertItem(index, item);
        }

        protected override void RemoveItem(int index)
        {
            _logger.Log(string.Format("Item {0} was removed from {1} index",Items[index].ToString(), index));
            _logger.Log(Items[index]);
            base.RemoveItem(index);
        }

        protected override void SetItem(int index, T item)
        {
            _logger.Log(string.Format("Item {0} was replaced with {1} item on {2} index", Items[index], item, index));
            _logger.Log(item);
            base.SetItem(index, item);
        }
    }

    class MyLogger : ILogger
    {
        readonly List<Object> _logList = new List<object>(); 
        public void Log(params object[] listToLog)
        {
            _logList.AddRange(listToLog);
        }

        public void ShowAllItems()
        {
            foreach (var item in _logList)
            {
                var @is = item as ICollection;
                if (@is != null)
                {
                    foreach (var i in @is)
                    {
                        Console.WriteLine(i.ToString());
                    }
                }
                else
                {
                    Console.WriteLine(item);
                }
            }
        }
    }

    interface ILogger
    {
        void Log(params object[] listToLog);

    }
}
