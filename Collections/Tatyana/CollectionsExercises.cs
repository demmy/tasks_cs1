using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Tatyana
{
    class CollectionsExercises : ICollectionsExercises
    {
        public void WorkPriorityQueue()
        {
            PriorityQueue<int> numbers = new PriorityQueue<int>();
            numbers.Add(10);
            numbers.Enqueue(2, 11);
            Console.WriteLine(numbers.First());
            Console.ReadKey();
        }
       
    }
}
