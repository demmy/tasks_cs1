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
            StringBuilder str= new StringBuilder("Hello!");
            str.Clear();
            str.AppendLine("This world is beatiful! And this string is changable!");
            Console.WriteLine("Good Day! {0}", str.ToString());
            Console.ReadKey();
        }
    }
}
