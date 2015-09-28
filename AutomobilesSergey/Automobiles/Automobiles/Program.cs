using System;
using System.Collections.Generic;
using Automobiles.Automobiles;

namespace Automobiles
{
    class Program
    {
        private static readonly List<Automobile> Garage = new List<Automobile>(); 
        private static void Dialog()
        {
            Console.WriteLine("Hello, welcome to our Autopark");
            while (true)
            {
                Console.WriteLine("What do you want?\n\t[1] Get new car\n\t[2] Drive a car\n\t[3] Exit\nType a number for action you want to do");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "1":
                        BuildNewCar();
                        break;
                    case "2":
                        DriveCar();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Cannot recognise the command, type 1,2 or 3");
                        break;
                }
            }
        }
        static void Main()
        {
            Dialog();
        }

        private static void BuildNewCar()
        {
            #region Init

            AutoBuilder builder = new AutoBuilder();
            string name = "";

            #endregion

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("What is name of  new car?");
                name = Console.ReadLine();
            }

            Console.WriteLine("What Car do want to create?\n");

            Console.WriteLine("1. Ukrainian?");
            Console.Write("2. or German?");

            Console.WriteLine("Select the index\n");
            var ind = int.Parse(Console.ReadLine());
            Console.WriteLine("What model do you want? - Type the index");
            int k = 0;
            switch (ind)
            {
                case 1:
                    foreach (string model in Enum.GetNames(typeof(UkrModels)))
                        Console.WriteLine("{0} {1}", ++k, model);
                    var modelOfUkrCar = (UkrModels) int.Parse(Console.ReadLine());
                    builder.GetUkrainianAutomobile(name, modelOfUkrCar);
                    break;
                case 2:
                    foreach (string model in Enum.GetNames(typeof(GerModels)))
                        Console.WriteLine("{0} {1}", ++k, model);
                    var modelOfGerCar = (GerModels) int.Parse(Console.ReadLine());
                    builder.GetGermanAutomobile(name, modelOfGerCar);
                    break;
            }
            Console.WriteLine("\nNice, creation of new car has finnished");
        }

        private static void DriveCar()
        {
            for (int i = 0; i < Garage.Count; i++)
                Console.WriteLine("{0} {1}", i+1, Garage[i].Title);
            
            Console.WriteLine("Select the car you wanna drive by index");
            int ind = int.Parse(Console.ReadLine());
            var car = Garage[ind];
            car.Start();
            while (car.FuelCapacity> 0)
            {
                //Here should be the selecting of what user car do in car
            }
            car.Stop();
        }
    }
}
