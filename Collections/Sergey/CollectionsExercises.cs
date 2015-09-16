using System;
using Collections.Sergey.Models;
using Collections.Sergey.Collections;
using Collections.Sergey.Loger;

namespace Collections.Sergey
{
    class CollectionsExercises : ICollectionsExercises
    {
        public void WorkPriorityQueue()
        {
            var intPriorityQueue = new PriorityQueue<int>();
            var stringPriorityQueue = new PriorityQueue<string>();
            var userPriorityQueue = new PriorityQueue<User>();

            try
            {
                intPriorityQueue.Enqueue(5, 1);
                intPriorityQueue.Enqueue(40, 1);
                Console.WriteLine("Number of elements of 1st order in queue = {0}", intPriorityQueue.GetCount(1));
                Console.WriteLine("First element of 1st priority = {0}", intPriorityQueue.First());
                Console.WriteLine("Last element of 1st priority = {0}", intPriorityQueue.Last());
                intPriorityQueue.Dequeue();
                intPriorityQueue.Enqueue(671, 2);
                intPriorityQueue.Enqueue(30, 4);
                intPriorityQueue.Enqueue(8932, 4);
                Console.WriteLine("First element of 4th priority = {0}", intPriorityQueue.First(4));
                Console.WriteLine("Last element of 4th priority = {0}", intPriorityQueue.Last(4));
                Console.WriteLine("Queue length = {0}", intPriorityQueue.Count);


                stringPriorityQueue.Enqueue("", 7);
                stringPriorityQueue.Enqueue("40", 7);
                //Console.WriteLine("Number of elements of 1st order in queue = {0}", stringPriorityQueue.GetCount(1));
                Console.WriteLine("First element of 1st priority = {0}", stringPriorityQueue.First());
                Console.WriteLine("Last element of 1st priority = {0}", stringPriorityQueue.Last());
                stringPriorityQueue.Dequeue();
                stringPriorityQueue.Enqueue("thirteen", 4);
                stringPriorityQueue.Enqueue("god", 4);
                Console.WriteLine("First element of 4th priority = {0}", stringPriorityQueue.First(4));
                Console.WriteLine("Last element of 4th priority = {0}", stringPriorityQueue.Last(4));
                Console.WriteLine("Queue length = {0}", stringPriorityQueue.Count);


                userPriorityQueue.Enqueue(new User("Bardara", "Morgrad", new DateTime(1992, 12, 5)), 1);
                userPriorityQueue.Enqueue(new User("Viki", "Crachkovic", new DateTime(1982, 2, 5)), 2);
                Console.WriteLine("Number of elements of 1st order in queue = {0}", userPriorityQueue.GetCount(1));
                Console.WriteLine("First element of 1st priority = {0}", userPriorityQueue.First().FullName);
                Console.WriteLine("Last element of 1st priority = {0}", userPriorityQueue.Last().FullName);
                userPriorityQueue.Dequeue();
                userPriorityQueue.Enqueue(new User("Somalien", "Fred", new DateTime(1976, 12, 5)), 2);
                //Console.WriteLine("First element of 4th priority = {0}", userPriorityQueue.First(4).FullName);
                //Console.WriteLine("Last element of 4th priority = {0}", userPriorityQueue.Last(4).FullName);
                Console.WriteLine("Queue length = {0}", userPriorityQueue.Count);
                MySimpleCollectionTesting();
                StudentDictionaryTesting();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured - {0}", e.Message);
            }
            Console.ReadKey();
        }

        private void MySimpleCollectionTesting()
        {
            MyLoger loger = new MyLoger();
            var simpleTestCollection = new MySimpleCollection<decimal>(loger)
            {
                45,
                32,
                67,
                23478
            };
            simpleTestCollection.Insert(2, 33);
            simpleTestCollection.Remove(23478);
            simpleTestCollection[3] = 41;
            simpleTestCollection.Clear();
            foreach (var log in loger.Logs)
                Console.WriteLine(log);
        }

        private void StudentDictionaryTesting()
        {
            StudentDictionary studentDictionary = new StudentDictionary 
            {
                new Student("Albert", "Guiness", new DateTime(1426,2,1)),
                new Student("Peter", "Stranford", new DateTime(1963, 4, 2))
            };
            foreach (var key in studentDictionary.Keys)
                Console.WriteLine("<<<<{0} {1} in Student(Keyed)Collection", key.Item1, key.Item2);
        }
    }
}
