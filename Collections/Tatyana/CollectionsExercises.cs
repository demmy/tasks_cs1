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
            WorkWithPriorityQueue();


        }

        static void WorkWithPriorityQueue()
        {
            PriorityQueue<int> numbers = new PriorityQueue<int>();
            try
            {
                Console.WriteLine("Count = {0}", numbers.Count());
                //Console.WriteLine(numbers.First());
                //Console.WriteLine(numbers.Last());
                //numbers.Add(10);
               // Print(numbers);
                numbers.Enqueue(1, 5);
                numbers.Enqueue(2, 11);
                numbers.Enqueue(1, 1);
               // Print(numbers);
                numbers.Enqueue(2, 1);
                numbers.Enqueue(3, 1);
                numbers.Enqueue(15, 2);
                numbers.Enqueue(25, 2);
                numbers.Enqueue(21, 2);
              //  Print(numbers);
                numbers.Enqueue(1021, 3);
                numbers.Enqueue(375, 5);
                numbers.Enqueue(124243323, 8);
              //  Print(numbers);
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
                Console.WriteLine(numbers.Dequeue());
             //   Print(numbers);
                Console.WriteLine(numbers.Dequeue());
                Console.WriteLine(numbers.Dequeue());
                Console.WriteLine(numbers.Dequeue());
              //  Print(numbers);
                Console.WriteLine(numbers.Dequeue());
                Console.WriteLine(numbers.Dequeue());
                Console.WriteLine(numbers.Dequeue());
             //   Print(numbers);
                Console.WriteLine("Count = {0}", numbers.Count());
                Console.WriteLine("Count with priority 1= {0}", numbers.GetCount(1));
                Console.WriteLine("Count with priority 2= {0}", numbers.GetCount(2));
                Console.WriteLine("Count with priority 3= {0}", numbers.GetCount(3));
                Console.WriteLine("Count with priority 4= {0}", numbers.GetCount(4));
                Console.WriteLine("Count with priority 5= {0}", numbers.GetCount(5));
                Console.WriteLine("Count with priority 8= {0}", numbers.GetCount(8));
                Console.WriteLine("Count with priority 11= {0}", numbers.GetCount(11));
                numbers.Clear();
                Console.WriteLine("Count = {0}", numbers.Count<int>());
             //   Print(numbers);

                numbers.Add(10);
                numbers.Add(11);
                Console.WriteLine(numbers.First());
                Console.WriteLine(numbers.Last());
                Console.WriteLine();
                numbers.Enqueue(1, 5);
                numbers.Add(5);
                Print(numbers);
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Is Exeption");
            }
            Console.ReadKey();
        }

        static void Print(PriorityQueue<int> queue)
        {
            Console.WriteLine("Queue");
           
           
                foreach (var t in queue)
                {
                    Console.Write(" {0} ,", t);
                }
                Console.WriteLine();
            
        }
    }
}
