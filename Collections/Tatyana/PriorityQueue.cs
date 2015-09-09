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

        private int Min()
        {
            int n = 0;
            foreach (int i in elements.Keys)
            {
                if (i < n)
                    n = i;
            }
            return n;
        }

        private int Max()
        {
            int n = 0;
            foreach (int i in elements.Keys)
            {
                if (i > n)
                    n = i;
            }
            return n;
        }


        public T Dequeue()
        {
            T a = elements[Max()].ElementAt(0);
            elements[Max()].Remove(a);
            return a;
            
        }

        public T First()
        {
            T a = elements[Max()].ElementAt(0);
            return a;
            
        }

        public T First(int priority)
        {
            T a = elements[priority].ElementAt(0);
            return a;
        }

        public T Last()
        {
            T a = elements[Min()].ElementAt(elements[Min()].Count-1);
            return a;
           
        }

        public T Last(int priority)
        {
            T a = elements[priority].ElementAt(elements[Min()].Count - 1);
            return a;
        }

        public int Count()
        {
            int n=0;
            foreach (int i in elements.Keys)
            {
                n += elements[i].Count;
            }
            return n;
        }

        public int GetCount(int priority)
        {
            return elements[priority].Count;
        }


        int IPriorityQueue<T>.Count
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
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Add(T item)
        {
            elements[0].Add(item);
        }

        public void Clear()
        {
            Dictionary<int, List<T>> elements = new Dictionary<int, List<T>>();
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
                        
                        b=true;
                        break;
                    }
                }
            }
            return b;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            elements[0].Add(array[arrayIndex]);
        }

        int ICollection<T>.Count
        {
            get { return this.elements.Count; }
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
