using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Sergey;

namespace University
{
    class Program
    {   
      
        static void MainTatyana()
        {            
             #region h

            Tatyana.UniversityFactory factory = new Tatyana.UniversityFactory();
            Tatyana.University u2 = (Tatyana.University)factory.CreateUniversity("U2");
            
                        
           // u2.CurrentSchedule.W(new DateTime(2015, 9, 7));
          //  u2.CurrentSchedule.W(new DateTime(2015, 9, 13, 23, 59, 59));

            Tatyana.Group g = new Tatyana.Group(FacultyType.Economics, 1980, "ComputerScience");
            Tatyana.Group g1 = new Tatyana.Group(FacultyType.Economics, 1980, "ComputerScience");
            Tatyana.Group g2 = new Tatyana.Group(FacultyType.Economics, 1980, "ComputerScience");
            Console.WriteLine("{0} {1}", g.ID, g.Faculty);
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

            Console.WriteLine("\n\r            List of rooms        \n\r");
            foreach (string room in u2.RoomsNames)
                Console.WriteLine(room);
            Console.WriteLine("\n\r             List of teachers        \n\r");
            foreach (string teacher in u2.TeachersNames)
                Console.WriteLine(teacher);
            Console.WriteLine("\n\r             List of groups        \n\r");
            foreach (string group in u2.GroupsNames)
                Console.WriteLine(group);
            Console.WriteLine("\n\r             List of student        ");
            foreach (string group in u2.GroupsNames)
            {
                Console.WriteLine("   list of student  Of group {0}      ", group );
                foreach (string student in u2.GetStudentsNames(group))
                    Console.WriteLine(student);
            }
            ISchedule schedule = u2.CurrentSchedule;
            Console.WriteLine("\n\r ----------------------------------------\n\r");
            
            IReadOnlyDictionary<string, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>> q1 =
                u2.CurrentSchedule.GetByDay(new DateTime(2015, 9, 10));
            IReadOnlyDictionary<DateTime, IReadOnlyDictionary<string,
        IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>> q2 =
            u2.CurrentSchedule.GetAll();

            #region q1
            Console.WriteLine();
            Console.WriteLine("   TimeTable for date       ");
            foreach (string d in q1.Keys)
            {
                Console.WriteLine(d);
                Console.WriteLine("-----");
                foreach (var t2 in q1[d])
                {
                    Console.WriteLine("Time of start lesson {0} ", t2.Item1);

                    Console.Write("Teachers --------------------");
                    foreach (string s in t2.Item2)
                        Console.Write("{0} ,  ",s);
                    Console.WriteLine();
                    Console.Write("Groups ---------------------");
                    foreach (string s in t2.Item3)
                        Console.Write("{0} ,   ",s);
                    Console.WriteLine();
                    Console.WriteLine();
                }
                Console.WriteLine("-----");
                Console.WriteLine();
            }

#endregion

            #region q2

            Console.WriteLine("   TimeTable for rooms  for all date     ");

            foreach (DateTime date in q2.Keys)
            {
                Console.WriteLine(date);
                foreach (string d in q2[date].Keys)
                {
                    Console.WriteLine(d);
                    foreach (var t in q2[date][d])
                    {
                        Console.WriteLine("{0}  ", t.Item1);
                        Console.Write("Teachers ----------------");
                        foreach (string s in t.Item2)
                            Console.Write("{0} ,  ", s);
                        Console.WriteLine();
                        Console.Write("Groups ------------------");
                        foreach (string s in t.Item3)
                            Console.Write("{0} ,  ", s);
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine();
           
            #endregion
            

            
            Dictionary<string, IReadOnlyDictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>> q3 =
                new Dictionary<string,IReadOnlyDictionary<DateTime,IReadOnlyList<Tuple<DateTime,IReadOnlyList<string>,IReadOnlyList<string>>>>>();
            foreach (string r in u2.RoomsNames)
                q3[r]=u2.CurrentSchedule.GetByRoom(r);

            Dictionary<string, IReadOnlyDictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, bool>>>> q4 =
                new Dictionary<string, IReadOnlyDictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, bool>>>>();
            foreach (string q in u2.GroupsNames )
                q4[q]= u2.CurrentSchedule.GetByGroup(q);

            Dictionary<string, IReadOnlyDictionary<DateTime, IReadOnlyList<Tuple<DateTime, string, IReadOnlyList<string>>>>> q5 =
                new Dictionary<string, IReadOnlyDictionary<DateTime, IReadOnlyList<Tuple<DateTime, string, IReadOnlyList<string>>>>>();
            foreach (string q in u2.TeachersNames )
                q5[q]=u2.CurrentSchedule.GetByTeacher(q);

            IReadOnlyDictionary<Tuple<DateTime, LessonsOrder>, IReadOnlyList<Tuple<IRoom, IReadOnlyList<IReadOnlyTeacher>,
               IReadOnlyList<IReadOnlyGroup>>>> week = u2.CurrentSchedule.GetWeekData(DateTime.Now);

            #region q3

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("   TimeTable for rooms       ");
            Console.WriteLine();

            foreach (string q in q3.Keys)
            {  
                
                foreach (DateTime date in q3[q].Keys )
                {

                    foreach (var t in q3[q][date])
                    {
                        Console.WriteLine("{0}  ",  t.Item1);
                        Console.Write("Teachers ---------------------------");
                        foreach (string s in t.Item2)
                            Console.Write("{0} ,  ", s);
                        Console.WriteLine();
                        Console.Write("Groups ---------------------------");
                        foreach (string s in t.Item3)
                            Console.Write("{0} ,  ", s);
                        Console.WriteLine();
                    }
                }
            }

            #endregion

            #region q4
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("   TimeTable for teachers       ");
            Console.WriteLine();

            foreach (var q in q4.Keys)
            {
                foreach (DateTime date in q4[q].Keys)
                {

                    foreach (var t in q4[q][date] )
                    {
                        Console.WriteLine("{0}  ",  t.Item1);
                        Console.Write("Teachers ---------------------------");
                        foreach (string s in t.Item2)
                            Console.Write("{0} ,  ", s);
                        Console.WriteLine();
                        Console.Write(t.Item3?"more then 1 group":"1 group on lection");
                        Console.WriteLine();
                    }
                }
            }

            #endregion 

            #region q5
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("   TimeTable for group       ");
            Console.WriteLine();

            foreach (var q in q5.Keys)
            {
                foreach (DateTime date in q5[q].Keys)
                {

                    foreach (var t in q5[q][date])
                    {
                        Console.WriteLine("{0} ",  t.Item1);
                        Console.Write("Room ---------------------------");
                        Console.WriteLine("{0}   ",t.Item2);
                        Console.Write("Groups ---------------------------");
                        foreach (string s in t.Item3)
                            Console.Write("{0} ,  ", s);
                        Console.WriteLine();
                        
                    }
                }
            }

            #endregion

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("              TimeTable for all days of week        ");
            Console.WriteLine();
            Console.WriteLine();
            foreach (var dateTimeLesson in week.Keys)
            {
                Console.WriteLine("{0}     {1} ", dateTimeLesson.Item1, dateTimeLesson.Item2);

                foreach (var t in week[dateTimeLesson ])
                {
                    Console.WriteLine("Room                      {0} ",t.Item1.Id);
                    Console.Write("Teachers ---------------------------");
                    foreach (IReadOnlyTeacher s in t.Item2)
                        Console.Write("{0} , ", s.FullName);
                    Console.WriteLine();
                    Console.Write("Groups ---------------------------");
                    foreach (IReadOnlyGroup s in t.Item3)
                        Console.Write("{0} ,   ", s.ID);
                    Console.WriteLine();

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
            IUniversityFactory factory = new Sergey.UniversityFactory();
            var univer = factory.CreateUniversity("Dnipropetrovs'k National University named after Oles' Gonchar");
            
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
            #endregion
    }
}
