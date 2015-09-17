using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Tatyana
{
    class PriorityQueue<T> :IPriorityQueue<T> , ICollection<T>
    {
        Dictionary<int, List<T>> elements = new Dictionary<int, List<T>>();

        public void Enqueue(T val, int priority)
        {
            if (!elements.ContainsKey(priority))
            {
                elements[priority] = new List<T>();
            }
            elements[priority].Add(val);

        }

        private int MinPriority()
        {
            int n = int.MinValue;
            if (elements.Keys.Count > 0)
            {
                n = elements.Keys.ElementAt<int>(0);

                foreach (int i in elements.Keys)
                {
                    if (i < n)
                        n = i;
                }
             }
            return n;
        }

        private int MaxPriority()
        {
            int n = int.MaxValue;
            if (elements.Keys.Count > 0)
            {
                n = elements.Keys.ElementAt<int>(0);

                foreach (int i in elements.Keys)
                {
                    if (i > n)
                        n = i;
                }
            }
            return n;
        }

        private int NextPriority()
        {
            int n=MinPriority();
            int m=0;
            int pred=n;
                if (elements.Count>1)
                {
                    pred = elements.Keys.ElementAt<int>(0);
                    foreach (int i in elements.Keys)
                    {
                        if (i > n)
                        {
                            m = i;
                        }
                    }
                }
        }

        public T Dequeue()
        {
            if (elements.Count > 0)
            {   
                int i=MaxPriority();
                T a = elements[i].ElementAt(0);
                elements[i].Remove(a);
                if (elements[i].Count == 0)
                {
                    elements.Remove(i);

                }
                return a;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public T First()
        {
            if (elements.Count > 0)
            {
                T a = elements[MaxPriority()].ElementAt(0);
                return a;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public T First(int priority)
        {
            if (elements.ContainsKey(priority))
            {
                T a = elements[priority].ElementAt(0);
                return a;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public T Last()
        {
            if (elements.Count > 0)
            {
                T a = elements[MinPriority()].ElementAt(elements[MinPriority()].Count - 1);
                return a;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public T Last(int priority)
        {
            if (elements.ContainsKey(priority))
            {
                T a = elements[priority].ElementAt(elements[MinPriority()].Count - 1);
                return a;
            }
            else
            {
                throw new NotImplementedException();
            }
         }

        

        public int GetCount(int priority)
        {
                return elements.ContainsKey(priority)? elements[priority].Count:0;
        }


       public int Count
        {
            get {
                int n = 0;
                foreach (int i in elements.Keys)
                {
                    n += elements[i].Count;
                }
                return n;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (elements.Count > 0)
            {
               foreach (int i in elements.Keys)
                {
                        foreach (var t in elements[i])
                        {
                            yield return t;
                        }
                  }
                }
            
            
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            int i = MinPriority();
            if (this.Count==0)
            {
                elements[i] = new List<T>();
            }
            
           elements[i].Add(item);
        }

        public void Clear()
        {
            elements = new Dictionary<int, List<T>>();
        }

        public bool Contains(T item)
        {
            bool b = false;
            foreach (int i in elements.Keys)
            {
                foreach (T e in elements[i])
                {
                    if (object.Equals(e, item))
                    {
                        b = true;
                        break;
                    }
                }
            }
            return b;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            elements[MinPriority()].Add(array[arrayIndex]);
        }

        

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(T item)
        {
            bool b = false;
            foreach (int i in elements.Keys)
            {
                foreach (T e in elements[i])
                {
                    if (object.Equals(e, item))
                    {
                        elements[i].Remove(e);
                        b = true;

                    }
                }
            }
            return b;
        }
    }
}
