using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Program
    {
        static void MainTatyana()
        {
            
            Tatyana.UniversityFactory factory=new Tatyana.UniversityFactory();
            Tatyana.University u2=(Tatyana.University)factory.CreateUniversity("U2");

            //List<Tatyana.Room> rooms = factory.CreateListRooms(10, 4);
            //List<Tatyana.Teacher> teachers = factory.CreateListTeacher(11);

            //List<Group> groups = CreateListGroupsWithStudents(3, 5, 1, 2);
            //Schedule schedule = new Schedule();
            //return new University(title, groups, teachers, rooms, schedule);

            Tatyana.Group g = new Tatyana.Group(FacultyType.Economics, 1980, "ComputerScience");
            Tatyana.Group g1 = new Tatyana.Group(FacultyType.Economics, 1980, "ComputerScience");
            Tatyana.Group g2 = new Tatyana.Group(FacultyType.Economics, 1980, "ComputerScience");
            Console.WriteLine("{0} {1}", g.ID, g.Faculty );
            Console.WriteLine("{0} {1}", g1.ID, g1.Faculty);
            Console.WriteLine("{0} {1}", g2.ID, g2.Faculty);

            Tatyana.Student s1 = factory.CreateRandomStudent();
            Tatyana.Student s2 = factory.CreateRandomStudent();
            Tatyana.Student s3 = factory.CreateRandomStudent();

            Console.WriteLine("{0} {1} ", s1.FullName, s1.Age);
            Console.WriteLine("{0} {1} ", s2.FullName, s2.Age);
            Console.WriteLine("{0} {1} ", s3.FullName, s3.Age);

            g.Add(s1);
            g.Add(s2);
            g.Add(s3);

            Console.WriteLine("--------");
            foreach (Tatyana.Student s in g.Students)
                Console.WriteLine("{0} {1} ", s.FullName, s.Age);

            Console.WriteLine("----------------------------");
            u2.AddRoom(new Tatyana.Room(Tatyana.Building.A, 1));
            u2.AddRoom(new Tatyana.Room(Tatyana.Building.A, 5));
            u2.AddGroup(new Tatyana.Group(FacultyType.Languages, 2008, "English"));
            u2.AddGroup(new Tatyana.Group(FacultyType.Languages, 2008, "German"));

            foreach (string room in u2.RoomsNames)
                Console.WriteLine(room);
            foreach (string teacher in u2.TeachersNames)
                Console.WriteLine(teacher);
            foreach (string group in u2.GroupsNames)
                Console.WriteLine(group);
            foreach (string group in u2.GroupsNames)
                foreach (string student in u2.GetStudentsNames(group))
                    Console.WriteLine(student);

            ISchedule schedule = u2.CurrentSchedule;
            Console.WriteLine("----------------------------");
            Console.ReadKey();
            IReadOnlyDictionary<string, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>> q1=
                u2.CurrentSchedule.GetByDay(new DateTime(2015, 9, 10));
            IReadOnlyDictionary<DateTime, IReadOnlyDictionary<string,
        IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>> q2 =
            u2.CurrentSchedule.GetAll();
            
                foreach (string d in q1.Keys)
                {
                    Console.WriteLine(d);
                    
                    foreach (var t2 in q1[d])
                    {
                        Console.WriteLine("{0}  {1}", d, t2.Item1);
                        
                        Console.Write("Teachers ---------------------------");
                        foreach (string s in t2.Item2)
                            Console.Write(s);
                        Console.WriteLine();
                        Console.Write("Groups ---------------------------");
                        foreach (string s in t2.Item3)
                            Console.Write(s);
                        Console.WriteLine();
                    }
                }
                foreach (DateTime date in q2.Keys)
                {
                    foreach (string d in q2[date].Keys)
                    {
                        foreach (var t in q2[date][d])
                        {
                            Console.WriteLine("{0}  {1}", d, t.Item1);
                            Console.Write("Teachers ---------------------------");
                            foreach (string s in t.Item2)
                                Console.Write(s);
                            Console.WriteLine();
                            Console.Write("Groups ---------------------------");
                            foreach (string s in t.Item3)
                                Console.Write(s);
                            Console.WriteLine();
                        }
                    }
                }
            Console.WriteLine();

            
            List<IReadOnlyDictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>> q3 =
                new List<IReadOnlyDictionary<DateTime,IReadOnlyList<Tuple<DateTime,IReadOnlyList<string>,IReadOnlyList<string>>>>>();
            foreach (string r in u2.RoomsNames )
                          q3.Add( u2.CurrentSchedule.GetByRoom(r) ) ;


               
            IReadOnlyDictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, bool>>> q4 =
                u2.CurrentSchedule.GetByGroup("En-08-1");

            IReadOnlyDictionary<DateTime, IReadOnlyList<Tuple<DateTime, string, IReadOnlyList<string>>>> q5 =
                u2.CurrentSchedule.GetByTeacher(u2.TeachersNames.ElementAt<string>(0));

            //IReadOnlyDictionary<Tuple<DateTime, LessonsOrder>, IReadOnlyList<Tuple<IRoom, IReadOnlyList<IReadOnlyTeacher>,
            //   IReadOnlyList<IReadOnlyGroup>>>> week = u2.CurrentSchedule.GetWeekData(DateTime.Now);

            Console.WriteLine("---------------------------------------------------------------");
            foreach (var q in q3)
            {
                foreach (DateTime date in q.Keys)
                {
                    
                    foreach (var t in q[date])
                    {
                        Console.WriteLine("{0}  {1}", date, t.Item1);
                        Console.Write("Teachers ---------------------------");
                        foreach (string s in t.Item2)
                            Console.Write(s);
                        Console.WriteLine();
                        Console.Write("Groups ---------------------------");
                        foreach (string s in t.Item3)
                            Console.Write(s);
                        Console.WriteLine();
                    }
                }
            }
            foreach (DateTime f in u2.CurrentSchedule.AllExistingDates)
            {
                Console.WriteLine(f);
            }

            Console.ReadKey();
        }

        static void MainTaisiya()
        {
        
        }

        static void MainSergey()
        {
        
        }

        static void MainNikita()
        {
        
        }

        static void Main(string[] args)
        {
            try
            {
                if (args.Length > 0)
                {
                    Console.WriteLine("Argument: {0}", args[0]);
                    switch (args[0])
                    {
                        case "Tatyana":
                            MainTatyana();
                            break;
                        case "Taisiya":
                            MainTaisiya();
                            break;
                        case "Nikita":
                            MainNikita();
                            break;
                        case "Sergey":
                            MainSergey();
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Not all code implemented. Problem: {0}", e.Message);
                Console.WriteLine("Details: {0}", e.ToString());
            }
        }


       
    }
}
