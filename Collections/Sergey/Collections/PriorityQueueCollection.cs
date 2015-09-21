using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collections.Sergey.Collections
{
    partial class PriorityQueue<T>: ICollection<Tuple<int, T>>
    {
        public IEnumerator<Tuple<int, T>> GetEnumerator()
        {
            return (from grList in _queue
                from item in grList.Value
                select new Tuple<int, T>(grList.Key, item)).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Tuple<int, T> item)
        {
           Enqueue(item.Item2, item.Item1);
        }

        public void Clear()
        {
            _queue.Clear();
        }

        public bool Contains(Tuple<int, T> item)
        {
            return _queue.ContainsKey(item.Item1) && _queue[item.Item1].Contains(item.Item2);
        }

        public void CopyTo(Tuple<int, T>[] array, int arrayIndex)
        {
            array.CopyTo((from grList in _queue
                from item in grList.Value
                select new Tuple<int, T>(grList.Key, item)).ToArray(), arrayIndex);
        }

        public bool Remove(Tuple<int, T> item)
        {
            return _queue.Remove(item.Item1);
        }

        public bool IsReadOnly
        {
            get { return true; }
        }
    }
}
