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
            Console.Clear();
            Console.WriteLine();
            Console.Write(mainMenu);
            while (!object.Equals(choose,"3"))
            {
            
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
            string plants = " [1] Создать автомобиль \n\r\n\r [2] Покататься \n\r\n\r [3] Выход  \n\r\n\r Ваш выбор = ";
            string a = "0";
            string name = "";
            Console.WriteLine("Введите имя автомобиля");
            name = Console.ReadLine();
            Console.WriteLine("Автомобиль какого именно завода мы создаём");
        }

        private     void GoForADrive()
        {
            Console.WriteLine("Выберите автомобиль");
                    foreach (var n in automobiles)
                        Console.WriteLine(n.Name);
        }

        private void EndWork()
        {
            Console.WriteLine("Завершение работы программы");
            
        }
            
        
    }
}
