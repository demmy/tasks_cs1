﻿using System;
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
            Console.WriteLine("+=======================================+");
            Console.ReadKey();
            Console.WriteLine("Strange merge...");
            Console.WriteLine("Well, hello creepy world...");
            
            
            Console.ReadLine();
            StringBuilder str= new StringBuilder("Hello!");
            str.Clear();
            str.AppendLine("This world is beautiful! And this string is changeable!");
            Console.WriteLine("Good Day! {0}", str.ToString());
            Console.ReadKey();
        }
    }
}
