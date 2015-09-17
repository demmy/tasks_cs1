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
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        int ICollection<T>.Count
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }
    }
}
