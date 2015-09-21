using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Tatyana
{
    class MySingleCollection<T>: ICollection<T>
    {
        List<T> list = new List<T>();
        ILogger history;


        public MySingleCollection( ILogger h)

    {
        history = h;
    }

        public void Add(T item)
        {
            list.Add(item);
            history.Log("AddNewElement", item);
        }

        
        public void Clear()
        {

            history.Log("Delete all elements", list);
            list.Clear();

        }

        public bool Contains(T item)
        {
            return list.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            list.Add(array[arrayIndex]);
            history.Log("AddNewElement", array[arrayIndex]);
        }

        public int Count
        {
            get { return list.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(T item)
        {
            bool b = false;
            foreach (T i in list)
            {
                if (object.Equals(item, i))
                {
                    list.Remove(item);
                    history.Log("DeleteElement", item);
                    b = true;
                }
            }
            return b;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T t in list)
            {
                yield return t;
            }
            
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
