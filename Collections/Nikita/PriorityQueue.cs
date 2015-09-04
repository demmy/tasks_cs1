using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Nikita
{
    class PriorityQueue<T> : IPriorityQueue<T>
    {
        SortedDictionary<int, List<T>> _itemsList = new SortedDictionary<int, List<T>>();

        public void Enqueue(T val, int priority)
        {

            if (_itemsList.ContainsKey(priority))
            {
                _itemsList[priority].Add(val);
            }
            else
            {
                _itemsList.Add(priority, new List<T>()
                {
                    val
                });
            }
        }

      public T Dequeue()
        {
            if (_itemsList.Count == 0) throw new InvalidOperationException("Queue is empty");
            T returnValue = _itemsList.ElementAt(0).Value[0];
            DeleteRoot();
            return returnValue;
        }

        private void DeleteRoot()
        {
            _itemsList.ElementAt(0).Value.RemoveAt(0);
            if (_itemsList.ElementAt(0).Value.Count < 1) _itemsList.Remove(_itemsList.ElementAt(0).Key);

        }

        public T First()
        {
            if (_itemsList.Count == 0) throw new InvalidOperationException("Queue is empty");
            T returnValue = _itemsList.ElementAt(0).Value[0];
            return returnValue;
        }

        public T First(int priority)
        {
            if (_itemsList.Count == 0) throw new InvalidOperationException("Queue is empty");
            T returnValue = _itemsList[priority][0];
            return returnValue;
        }

        public T Last()
        {
            if (_itemsList.Count == 0) throw new InvalidOperationException("Queue is empty");
            T returnValue =
                _itemsList.ElementAt(_itemsList.Count - 1).Value[
                    _itemsList.ElementAt(_itemsList.Count - 1).Value.Count - 1];
            return returnValue;
        }

        public T Last(int priority)
        {
            if (_itemsList.Count == 0) throw new InvalidOperationException("Queue is empty");
            T returnValue = _itemsList[priority][_itemsList[priority].Count];
            return returnValue;
        }

        public int Count
        {
            get
            {
                return _itemsList.Values.Sum(list => list.Count);
            }
        }

        public int GetCount(int priority)
        {
            return _itemsList[priority].Count;
        }
    }
}
