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
            char[] hellowords = new char[]
            {
                'H', 'e', 'l', 'l', 'o', ' ', 'W', 'o', 'r', 'l', 'd'
            };
            foreach (var word in hellowords)
            {
                Console.Write(word);
            }
            Console.ReadKey();
        }
    }
}
