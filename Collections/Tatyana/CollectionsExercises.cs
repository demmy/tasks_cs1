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
            WorkWithStudentDictionary();
            WorkWithMySingleCollection();
        }

        static void WorkWithMySingleCollection()
        {
            MyLogger logger = new MyLogger();
            MySingleCollection<int> collection = new MySingleCollection<int>(logger);
            MySingleCollection<DateTime> collectionDate = new MySingleCollection<DateTime>(logger);
            collection.Add(5);
            collection.Add(11);
            collection.Add(25);
            collection.Insert(1, 8);
            collection.Remove(23);
            collection.Remove(11);
            collection[0] = 25;
            collection.Clear();
            collectionDate.Add(new DateTime(2005, 5, 4));
            Console.WriteLine( logger.AllInformation());
            foreach (string s in logger.Dates())
            {
                Console.WriteLine(s);
            }
            foreach (string s in logger.Information())
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(logger.IformationForDate(DateTime.Now) ) ;
            Console.WriteLine(logger.InformationBetweenDates(new DateTime( DateTime.Now.Ticks-1000),DateTime.Now) );


            Console.ReadKey();
        }
        static void WorkWithStudentDictionary()
        {
            Student s1 = new Student("N1", "M1");
            StudentDictionary students = new StudentDictionary();
            StudentDictionary newStudents =new StudentDictionary();
                students.Add(new Student("N121321","M24234" ));
            students.Add(new Student("N1232431321","M242343434" ));
            students.Add(new Student("N24323","M23243" ));
            newStudents.Add(new Student("N-05-1-1", "M2323"));
            newStudents.Add(new Student("Student","New") );
            PrintStudentDictionary(students);
            PrintStudentDictionary(newStudents);
            Console.WriteLine("{0}   {1}", students[0].FirstName, students[Tuple.Create<string,string>("N121321","M24234")].FirstName );
            Console.WriteLine("{0}   {1}", students[1].FirstName, students[Tuple.Create<string, string>("N1232431321", "M242343434")].FirstName);
            Console.ReadKey();
        }


        static void PrintStudentDictionary(StudentDictionary studentDictionary )
        {
            foreach (var s in studentDictionary)
            {
                Console.WriteLine("{0}   {1}",s.FirstName,s.LastName);
            }
        }

        static void WorkWithPriorityQueue()
        {
            PriorityQueue<int> numbers = new PriorityQueue<int>();
            try
            {
                Console.WriteLine("Count = {0}", numbers.Count());
                //Console.WriteLine(numbers.First());
               // Console.WriteLine(numbers.Last());
                numbers.Add(10);
                Print(numbers);
                numbers.Enqueue(1, 5);
                numbers.Enqueue(2, 11);
                numbers.Enqueue(1, 1);
                Print(numbers);
                numbers.Enqueue(2, 1);
                numbers.Enqueue(3, 1);
                numbers.Enqueue(15, 2);
                numbers.Enqueue(25, 2);
                numbers.Enqueue(21, 2);
                Print(numbers);
                numbers.Enqueue(1021, 3);
                numbers.Enqueue(375, 5);
                numbers.Enqueue(124243323, 8);
                Print(numbers);
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
                Print(numbers);
                Console.WriteLine(numbers.Dequeue());
                Console.WriteLine(numbers.Dequeue());
                Console.WriteLine(numbers.Dequeue());
                Print(numbers);
                Console.WriteLine(numbers.Dequeue());
                Console.WriteLine(numbers.Dequeue());
                Console.WriteLine(numbers.Dequeue());
                Print(numbers);
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
                Print(numbers);

                numbers.Add(10);
                numbers.Add(11);
                Console.WriteLine(numbers.First());
                Console.WriteLine(numbers.Last());
                Console.WriteLine();
                numbers.Enqueue(1, 5);
                numbers.Add(5);
                numbers.Enqueue(23, 1);
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
