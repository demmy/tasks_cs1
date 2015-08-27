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
