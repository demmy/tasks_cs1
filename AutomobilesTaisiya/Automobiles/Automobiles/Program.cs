using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string inputCarCountry;
            string rideInput;

            CarBuilder builder = new CarBuilder();
            List <ICar> cars = new List<ICar>();

            do
            {
                userInput = DisplayMenu();
                switch (userInput)
                {
                    #region CarCreation
                    case "1":
                        {
                            Console.WriteLine("Input car's name: ");
                            string name = Console.ReadLine();

                            inputCarCountry = CarCreateMenu();
                            switch (inputCarCountry)
                            {
                                case "1":
                                    {
                                        Console.WriteLine("1. BMW");
                                        Console.WriteLine("2. Mini");
                                        Console.WriteLine("Input car's model: ");
                                        int modelNum = Convert.ToInt32(Console.ReadLine());
                                        GermanCarModels model = (modelNum == 1) ? GermanCarModels.BMW : GermanCarModels.Mini;
                                        cars.Add(builder.CreateGermanCar(name, model));
                                    }
                                    break;

                                case "2":
                                    {
                                        Console.WriteLine("1. ZAZ");
                                        Console.WriteLine("2. LADA");
                                        Console.WriteLine("Input car's model: ");
                                        int modelNum = Convert.ToInt32(Console.ReadLine());
                                        UkrainianCarModels model = (modelNum == 1) ? UkrainianCarModels.ZAZ : UkrainianCarModels.LADA;
                                        cars.Add(builder.CreateUkrainianCar(name, model));
                                    }
                                    break;
                                case "3": DisplayMenu();
                                    break;
                            }
                        }
                        break;
                    #endregion

                    #region Ride
                    case "2":
                        {
                            int i = 0;
                            foreach (var c in cars)
                                Console.WriteLine((i+1) + ". " + c.CarName);
                            Console.WriteLine("Choose the car before the ride: ");
                            int carNum = Convert.ToInt32(Console.ReadLine()) - 1;

                            rideInput = Ride();

                            do
                            {
                                switch (rideInput)
                                {
                                    case "1": cars.ElementAt(carNum).AcceleratorPedal();
                                        break;
                                    case "2": cars.ElementAt(carNum).TurnSteeringWheelLeft();
                                        break;
                                    case "3": cars.ElementAt(carNum).TurnSteeringWheelRight();
                                        break;
                                    case "4": cars.ElementAt(carNum).Lights();
                                        break;
                                    case "5": cars.ElementAt(carNum).AcceleratorPedal();
                                        break;
                                    case "6": cars.ElementAt(carNum).BreakPedal();
                                        break;
                                    case "7": cars.ElementAt(carNum).ShowDashboard();
                                        break;
                                    case "8": cars.ElementAt(carNum).BreakPedal();
                                        break;
                                    case "9": DisplayMenu();
                                        break;
                                }
                            } while (rideInput != "9");

 
                        }
                        break;
                    #endregion

                    case "3": Environment.Exit(0);
                        break;
                }
            } while (userInput != "3");
        }

        public static string DisplayMenu()
        {
            Console.WriteLine("\n============================================================================\n");
            Console.WriteLine("1. Create a car");
            Console.WriteLine("2. Have a ride");
            Console.WriteLine("3. Exit");
            Console.WriteLine("\n============================================================================\n");

            var result = Console.ReadLine();
            return result;
        }

        public static string CarCreateMenu()
        {
            Console.WriteLine("\nChoose a producer country:\n");
            Console.WriteLine("1. Germany");
            Console.WriteLine("2. Ukraine");
            Console.WriteLine("3. Back");
            Console.WriteLine("\n============================================================================\n");

            var result = Console.ReadLine();
            return result;
        }

        public static string Ride()
        {
            Console.WriteLine("\n============================================================================\n");
            Console.WriteLine("1. Start");
            Console.WriteLine("2. Turn left");
            Console.WriteLine("3. Turn right");
            Console.WriteLine("4. Lights");
            Console.WriteLine("5. Gas");
            Console.WriteLine("6. Break");
            Console.WriteLine("7. Stop");
            Console.WriteLine("8. Show dashboard");
            Console.WriteLine("9. Back");
            Console.WriteLine("\n============================================================================\n");

            var result = Console.ReadLine();
            return result;
        }

    }
}
