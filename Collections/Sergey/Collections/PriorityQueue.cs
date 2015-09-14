using System.Collections.Generic;
using System.Linq;
using Collections.Sergey.Collections.Exceptions;

namespace Collections.Sergey.Collections
{
    partial class PriorityQueue<T>: IPriorityQueue<T>
    {
        private const string KeyNotFoundMessage = "There are no elements of such priority";
        private const string EmptyQueueMessage = "The queue is empty, nothing to dequeue";

        private int _count;
        private readonly Dictionary<int, List<T> > _queue = new Dictionary<int, List<T> >();

        public void Enqueue(T val, int priority)
        {
            if (!_queue.ContainsKey(priority))
                  _queue.Add(priority,
                      new List<T> 
                      { 
                        val
                      });
            else
                _queue[priority].Add(val);
            _count++;
        }

        public T Dequeue()
        {
            if (_count == 0)
                throw new EmptyPriorityQueueException(EmptyQueueMessage);
            int maxPriority = _queue.Keys.Min();
            T dequedElement = _queue[maxPriority].First();

            _queue[maxPriority].Remove(dequedElement);
            _count--;
            return dequedElement;
        }

        public T First()
        {
            if (_count == 0)
                throw new EmptyPriorityQueueException(EmptyQueueMessage);
            int maxPriority = _queue.Keys.Min();
            T firstElement = _queue[maxPriority].First();
            return firstElement;
        }

        public T First(int priority)
        {
            if (!_queue.ContainsKey(priority))
                throw new KeyNotFoundException(KeyNotFoundMessage);
            T firstElement = _queue[priority].First();
            return firstElement;
        }

        public T Last()
        {
            if (_count == 0)
                throw new EmptyPriorityQueueException(EmptyQueueMessage);
            int maxPriority = _queue.Keys.Min();
            T firstElement = _queue[maxPriority].Last();
            return firstElement;
        }

        public T Last(int priority)
        {
            if (!_queue.ContainsKey(priority))
                throw new KeyNotFoundException(KeyNotFoundMessage);
            T firstElement = _queue[priority].Last();
            return firstElement;
        }

        public int Count
        {
            get 
            {
                return _count;
            }
        }

        public int GetCount(int priority)
        {
            if (!_queue.ContainsKey(priority))
                throw new KeyNotFoundException(KeyNotFoundMessage);
            return _queue[priority].Count;
        }
    }
}
