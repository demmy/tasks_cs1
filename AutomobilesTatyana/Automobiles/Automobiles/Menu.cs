using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDetails;


namespace Automobiles
{
    
    class Menu
    {
        AutomobilesDictionary automobiles = new AutomobilesDictionary();
        PlantsDictionary plants;

        public Menu(PlantsDictionary plants1)
        {
            plants = plants1;
 
        }
        public void MainMenu()
        {
            string mainMenu = " [1] Создать автомобиль \n\r\n\r [2] Покататься \n\r\n\r [3] Выход  \n\r\n\r Ваш выбор = ";
            string choose ="0";
            
            while (!object.Equals(choose,"3"))
            {
                Console.Clear();
                Console.WriteLine();
                Console.Write(mainMenu);
            choose = Console.ReadLine().Trim();
            
            switch (choose)
            {
                case "1":
                    CreateCar();
                    break;
                case "2":
                    GoForADrive();
                    break;
                case "3":
                    EndWork();
                    break;
                default:
                    Console.WriteLine("Неправильный выбор");
                    break;
            }
            }
        }

            private void CreateCar()
        {
            
            string  point = "0";
            int a=0;
            string name = "";
            bool isCorrect = false;
            CarFactory factory = new CarFactory();
            Console.WriteLine("Введите имя автомобиля");
            while (object.Equals(name, ""))
            {
                Console.Write(" Имя автомобиля = ");
                name = Console.ReadLine().Trim();
                if (object.Equals(name, ""))
                {
                    Console.WriteLine("имя не может состоять только из пробелов");
                }
            }
            Console.WriteLine("Автомобиль какого именно завода мы создаём");
            for (int i = 0; i < plants.Count; i++)
            {
                Console.WriteLine(" {0} {1} \n\r", i + 1, plants[i].NameOfPlant);
            }
            while (!isCorrect)
            {
                Console.Write(" ваш выбор = ");
                point = Console.ReadLine().Trim();
                isCorrect = int.TryParse(point, out a) && (a >= 1) && (a <= plants.Count);
                if (!isCorrect)
                {
                    Console.WriteLine(" Сделайте правильный выбор ");
                }
            }
            a--;
            automobiles.Add( factory.CreateCar(name, plants[a]));
            Console.WriteLine("Создана машина {0} завода {1} ", name, plants[a].NameOfPlant);
            Console.ReadKey();

         }

        private     void GoForADrive()
            {
                string point = "0";
                int a = 0;
                bool isCorrect = false;
                if (automobiles.Count != 0)
                {

                    Console.WriteLine("Выберите автомобиль");
                    foreach (var n in automobiles)
                        Console.WriteLine(n.Name);
                    for (int i = 0; i < automobiles.Count; i++)
                    {
                        Console.WriteLine(" {0} {1} \n\r", i + 1, automobiles[i].Name);
                    }
                    while (!isCorrect)
                    {
                        Console.Write(" ваш выбор = ");
                        point = Console.ReadLine().Trim();
                        isCorrect = int.TryParse(point, out a) && (a >= 1) && (a <= plants.Count);
                        if (!isCorrect)
                        {
                            Console.WriteLine(" Сделайте правильный выбор ");
                        }
                    }
                }
                else
                {
                     Console.WriteLine("Не создано ни одного автомобиля");
                     Console.ReadKey();
                
                }
        }
        public void GoForADriveByCar(ICar car)
        {

        }
        private void EndWork()
        {
            Console.WriteLine("Завершение работы программы");
            
        }
            
        
    }
}
