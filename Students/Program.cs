using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            List<IStudentFactory> factories = new List<IStudentFactory>();
            factories.Add(new Tatyana.StudentFactory());
            factories.Add(new Taisiya.StudentFactory());
            factories.Add(new Sergey.StudentFactory());
            factories.Add(new Nikita.StudentFactory());
            factories.Add(new Aleksandr.StudentFactory());

            List<IStudent> students = new List<IStudent>();

            foreach(var factory in factories)
            {
                try
                {
                    for(int i=0; i<rnd.Next(10)+2; i++)
                    {
                        students.Add(factory.CreateRandomStudent());
                    }

                    Console.WriteLine("====== Calculation by programmer {0} =======", factory.ProgrammerName);
                    IMarksCalculator calculator = factory.MarksCalculator;

                    if (calculator != null)
                    {
                        foreach (var mark in calculator.AverageMarkPerStudent(students))
                        {
                            Console.WriteLine("Student {0} has average mark {1}", mark.Key.FullName, mark.Value);
                        }
                        foreach (var mark in calculator.AverageMarkPerSubject(students))
                        {
                            Console.WriteLine("Subject {0} has average mark {1}", mark.Key, mark.Value);
                        }
                        foreach (var mark in calculator.AverageMarkPerGroup(students))
                        {
                            Console.WriteLine("Group {0} has average mark {1}", mark.Key, mark.Value);
                        }
                        foreach (var mark in calculator.AverageMarkPerGroupPerSubject(students))
                        {
                            Console.WriteLine("Group {0} subject {1} has average mark {2}",
                                mark.Key.Item1, mark.Key.Item2, mark.Value);
                        }
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Not all initializations or calculations implemented. Problem: {0}", e.Message);
                    Console.WriteLine("Details: {0}", e.ToString());
                    continue;
                }
            }
            Console.ReadKey(true);
        }
    }
}
