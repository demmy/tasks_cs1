using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Taisiya
{
    class PriorityQueue<T> : IPriorityQueue<T>, ICollection<Tuple<T, int>>
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

        public void Clear()
        {
            List<int> keys = new List<int>();
            keys.AddRange(items.Keys);

            foreach (var k in keys)
                items.Remove(k);
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(Tuple<T, int> item)
        {
            if (!items.ContainsKey(item.Item2))
                items[item.Item2] = new List<T>();

            items[item.Item2].Add(item.Item1);
        }


        public bool Contains(Tuple<T, int> item)
        {
            bool flag = false;

            foreach (var it in items)
            {
                if (it.Key == item.Item2)
                    foreach (var i in it.Value)
                    {
                        if (i.ToString() == item.Item1.ToString())
                        {
                            flag = true;
                        }
                    }
            }
            return flag;
        }

        public void CopyTo(Tuple<T, int>[] array, int arrayIndex)
        {
            List<Tuple<T, int>> temp = new List<Tuple<T, int>>();

            for (int i = arrayIndex; i < array.Length; i++)
            {
                foreach (var its in items)
                    foreach (var it in its.Value)
                        temp.Add(Tuple.Create(it, its.Key));                        
                    
                array[i] = temp[i];
            }
        }

        public bool Remove(Tuple<T, int> item)
        {
            bool flag = false;

            foreach (var it in items)
            {
                if (it.Key == item.Item2)
                    foreach (var i in it.Value)
                    {
                        if (i.ToString() == item.Item1.ToString())
                        {
                            flag = true;
                            it.Value.Remove(item.Item1);
                        }
                    }
            }
            return flag;
        }

        public IEnumerator<Tuple<T, int>> GetEnumerator()
        {
            return (IEnumerator<Tuple<T, int>>)GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return (System.Collections.IEnumerator)GetEnumerator();
        }
    }
}
