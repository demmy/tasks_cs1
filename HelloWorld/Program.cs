using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Change hello world file";
            Console.WriteLine(message);
            Console.WriteLine("+========================================+");
            Console.WriteLine("+         HELLO     WORLD                +");
            StringBuilder str = new StringBuilder("Hello!");
            str.Clear();
            str.AppendLine("This world is beautiful! And this string is changeable!");
            Console.WriteLine("Good Day! {0}", str.ToString());
            Console.WriteLine("+========================================+");
            Console.ReadKey();
        }
    }
}
