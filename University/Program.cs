using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IUniversityFactory> factories = new List<IUniversityFactory>();
            factories.Add(new Tatyana.UniversityFactory());
            factories.Add(new Taisiya.UniversityFactory());
            factories.Add(new Sergey.UniversityFactory());
            factories.Add(new Nikita.UniversityFactory());
            factories.Add(new Aleksandr.UniversityFactory());

            foreach (var factory in factories)
            {
                try
                {
                    Console.WriteLine("Programmer: {0}", factory.ProgrammerName);

                    IUniversity university = factory.CreateUniversity("Super new university");
                    
                    //university.CurrentSchedule
                }
                catch (Exception e)
                {
                    Console.WriteLine("Not all code implemented. Problem: {0}", e.Message);
                    Console.WriteLine("Details: {0}", e.ToString());
                    continue;
                }
            }
        }
    }
}
