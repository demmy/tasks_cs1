using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Nikita
{
    class CollectionsExercises : ICollectionsExercises
    {
        public void WorkPriorityQueue()
        {
            PriorityQueue<string> pq = new PriorityQueue<string>();
            pq.Enqueue("Лалка", 4);
            pq.Enqueue("Палка", 3);
            pq.Enqueue("Стрелка", 7);
            pq.Enqueue("Дралка", 3);
            pq.Enqueue("Ломалка", 1);
            string deq = pq.Dequeue();
            int pCount = pq.GetCount(7);
            string first = pq.First();
            string last = pq.Last();
            string pLast = pq.Last(3);
        }
    }
}
