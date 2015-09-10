using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Taisiya
{
    class PriorityQueue<T> : IPriorityQueue<T>, ICollection<T>
    {
        private Dictionary<int, List<T>> items = new Dictionary<int, List<T>>();

        public void Enqueue(T val, int priority)
        {
            if (!items.ContainsKey(priority))
                items[priority] = new List<T>();

            items[priority].Add(val);

        }

        public void Enqueue(List<T> val, int priority)
        {
            if (!items.ContainsKey(priority))
                items[priority] = new List<T>();

            foreach (var v in val)
                items[priority].Add(v);
        }

        public T Dequeue()
        {
            if (items.Count == 0)
                throw new Exception("The queue is empty. Can't do dequeue.");
            else
            {
                T item = First();
                items[items.Keys.Min()].Remove(First());
                return item;
            }
        }

        public T First()
        {
            return First(items.Keys.Min());
        }

        public T First(int priority)
        {
            try
            {
                var item = items.Where(x => x.Key == priority).First().Value.First();
                return item;
            }
            catch (Exception e)
            {
                throw new Exception("There are not any elements with such priority in the queue.");
            }
        }

        public T Last()
        {
            return Last(items.Keys.Max());
        }

        public T Last(int priority)
        {
            try
            {
                var item = items.Where(x => x.Key == priority).Last().Value.Last();
                return item;
            }
            catch (Exception e)
            {
                throw new Exception("There are not any elements with such priority in the queue.");
            }
        }

        public int Count
        {
            get { return items.Values.Count; }
        }

        public int GetCount(int priority)
        {
            try
            {
                return items[priority].Count;
            }
            catch (Exception e)
            {
                throw new Exception("There are not any elements with such priority in the queue.");
            }
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }


        public void Clear()
        {
            List<int> keys = new List<int>();
            keys.AddRange(items.Keys);

            foreach (var k in keys)
                items.Remove(k);
        }

        public bool Contains(T item)
        {
            bool flag = false;

            foreach (var it in items)
            {
                foreach (var i in it.Value)
                {
                    if (i.ToString() == item.ToString())
                    {
                        flag = true;
                    }
                }
            }
            return flag;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return (System.Collections.IEnumerator)GetEnumerator();
        }
    }
}
