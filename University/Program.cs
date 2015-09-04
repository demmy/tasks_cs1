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
            Tatyana.University u1=(Tatyana.University)factory.CreateUniversity("U1");

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
            foreach (Tatyana.Student s in g.Students )
                Console.WriteLine("{0} {1} ",  s.FullName, s.Age);
            Console.WriteLine("----------------------------");
            //foreach (string room in u1.RoomsNames)
            //    Console.WriteLine(room);
            //foreach (string teacher in u1.TeachersNames)
            //    Console.WriteLine(teacher);
            //foreach (string group in u1.GroupsNames)
            //    Console.WriteLine(group);
            //foreach (string group in u1.GroupsNames)
            //    foreach(string student in u1.GetStudentsNames(group))
            //      Console.WriteLine(student);

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
