using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Tatyana
{
    class PriorityQueue<T> :IPriorityQueue<T>
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
            
        }

        public T First()
        {
            throw new NotImplementedException();
        }

        public T First(int priority)
        {
            throw new NotImplementedException();
        }

        public T Last()
        {
            throw new NotImplementedException();
        }

        public T Last(int priority)
        {
            throw new NotImplementedException();
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
    }
}
