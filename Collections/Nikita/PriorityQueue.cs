using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Nikita
{
    class PriorityQueue<T> : IPriorityQueue<T>, ICollection<T>
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
            var returnValue = First();
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
            if(!_itemsList.ContainsKey(priority)) throw new InvalidOperationException("No files with this priority");
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
            if (!_itemsList.ContainsKey(priority)) throw new InvalidOperationException("No files with this priority");
            T returnValue = _itemsList[priority][_itemsList[priority].Count];
            return returnValue;
        }

        public void Add(T item)
        {
            Enqueue(item, 5);
        }

        public void Clear()
        {
            _itemsList.Clear();
        }

        public bool Contains(T item)
        {
            return _itemsList.Any(pair => pair.Value.Contains(item));
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            List<T> interList = _itemsList.SelectMany(pair => pair.Value).ToList();
            interList.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            return _itemsList.Select(pair => pair.Value.Remove(item)).FirstOrDefault();
        }

        public int Count
        {
            get
            {
                return _itemsList.Values.Sum(list => list.Count);
            }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public int GetCount(int priority)
        {
            return _itemsList[priority].Count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _itemsList.SelectMany(pair => pair.Value).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
