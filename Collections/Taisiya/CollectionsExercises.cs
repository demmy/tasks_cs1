using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Taisiya
{
    class CollectionsExercises : ICollectionsExercises
    {
        public void WorkPriorityQueue()
        {
            PriorityQueue<string> q1 = new PriorityQueue<string>();
            PriorityQueue<int> q2 = new PriorityQueue<int>();
            PriorityQueue<Group> q3 = new PriorityQueue<Group>();

            q1.Enqueue(new List<string> { "A", "B", "C" }, 5);
            q1.Enqueue(new List<string> { "F", "G", "H" }, 1);
            q1.Enqueue(new List<string> { "X", "V", "B" }, 0);
            q1.Enqueue(new List<string> { "Q", "W", "E" }, 1);
            q1.Enqueue("Z", 1);

            q2.Enqueue(new List<int> { 4, 5, 6 }, 5);
            q2.Enqueue(new List<int> { 1, 2, 3 }, 1);
            q2.Enqueue(new List<int> { 7, 8, 9 }, 0);
            q2.Enqueue(new List<int> { 0, 3, 5 }, 1);
            q2.Enqueue(9, 2);

            q3.Enqueue(new Group("CS1", 7), 1);
            q3.Enqueue(new Group("CS2", 14), 3);
            q3.Enqueue(new Group("CS3", 24), 5);
            q3.Enqueue(new Group("CS4", 31), 1);



            Console.WriteLine("Dequeue in Q1: " + q1.Dequeue());
            Console.WriteLine("First in Q1: " + q1.First());
            Console.WriteLine("First with priority = 1 in Q1: " + q1.First(1));
            Console.WriteLine("Last in Q1: " + q1.Last());
            Console.WriteLine("Last with priority = 1 in Q1: " + q1.Last(1));
            Console.WriteLine("Count in Q1: " + q1.Count);
            Console.WriteLine("Count with priority = 1 in Q1: " + q1.GetCount(1));

            Console.WriteLine("__________________________________________________");

            Console.WriteLine("Dequeue in Q2: " + q2.Dequeue());
            Console.WriteLine("First in Q2: " + q2.First());
            Console.WriteLine("First with priority = 1 in Q2: " + q2.First(1));
            Console.WriteLine("Last in Q2: " + q2.Last());
            Console.WriteLine("Last with priority = 1 in Q2: " + q2.Last(1));
            Console.WriteLine("Count in Q2: " + q2.Count);
            Console.WriteLine("Count with priority = 1 in Q2: " + q2.GetCount(1));

            Console.WriteLine("__________________________________________________");

            Console.WriteLine("Dequeue in Q3: " + q3.Dequeue().Title);
            Console.WriteLine("First in Q3: " + q3.First().Title);
            Console.WriteLine("First with priority = 1 in Q3: " + q3.First(1).Title);
            Console.WriteLine("Last in Q3: " + q3.Last().Title);
            Console.WriteLine("Last with priority = 1 in Q3: " + q3.Last(1).Title);
            Console.WriteLine("Count in Q3: " + q3.Count);
            Console.WriteLine("Count with priority = 1 in Q3: " + q3.GetCount(1));


            Console.ReadLine();
        }
    }
}
