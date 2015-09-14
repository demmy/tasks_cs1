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
            Console.WriteLine("Count = {0}", numbers.Count());
            //numbers.Add(10);
            numbers.Enqueue(1, 5);
            numbers.Enqueue(2, 11);
            numbers.Enqueue(1, 1);
            numbers.Enqueue(2, 1);
            numbers.Enqueue(3, 1);
            numbers.Enqueue(15, 2);
            numbers.Enqueue(25, 2);
            numbers.Enqueue(21, 2);
            numbers.Enqueue(1021, 3);
            numbers.Enqueue(375, 5);
            numbers.Enqueue(124243323, 8);
            Console.WriteLine("Count = {0}", numbers.Count());
            Console.WriteLine("Count with priority 1= {0}", numbers.GetCount(1));
            Console.WriteLine("Count with priority 2= {0}", numbers.GetCount(2));
            Console.WriteLine("Count with priority 3= {0}", numbers.GetCount(3));
            Console.WriteLine("Count with priority 4= {0}", numbers.GetCount(4));
            Console.WriteLine("Count with priority 5= {0}", numbers.GetCount(5));
            Console.WriteLine("Count with priority 8= {0}", numbers.GetCount(8));
            Console.WriteLine("Count with priority 11= {0}", numbers.GetCount(11));
            Console.WriteLine(numbers.First());
            Console.WriteLine(numbers.Last());
            Console.ReadKey();
        }
       
    }
}
