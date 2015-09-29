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
            
            
            int a=0;
            string name = "";
            
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
            a = Point(plants.Count) - 1;
            automobiles.Add( factory.CreateCar(name, plants[a]));
            Console.WriteLine("Создана машина {0} завода {1} ", name, plants[a].NameOfPlant);
            Console.ReadKey(true);

         }

        private     void GoForADrive()
            {
                
                int a = 0;
                if (automobiles.Count != 0)
                {

                    Console.WriteLine("Выберите автомобиль");
                    foreach (var n in automobiles)
                        Console.WriteLine(n.Name);
                    for (int i = 0; i < automobiles.Count; i++)
                    {
                        Console.WriteLine(" {0} {1} \n\r", i + 1, automobiles[i].Name);
                    }
                    a=Point(automobiles.Count);
                }
                else
                {
                     Console.WriteLine("Не создано ни одного автомобиля");
                     Console.ReadKey();
                
                }
        }
        public void GoForADriveByCar(ICar car)
        {  double power=10;
            double angle =10;
            PrintStatusDrive(car.Name, car.Speed(), car.Direction(), car.Status, car.RemainderFuel(), power, angle, car.IsLight);
        }


        public void PrintStatusDrive(string name, double speed, double direction, StatusTransmission status, double remainder,
                                                                                      double power, double angle , bool isLight)
        {
            string information = "Вы катаететесь на машине {0} \n\r\n\r   Состояние:  \n\r   скорость       {1} км/ч \n\r"+
                "   направление       {2} градусов к северу от востока \n\r" +
                "   автомобиль       {3}   \n\r   фары       {4}    \n\r   остаток топлива в баке       {5}    \n\r\n\r" +
                "  Действия:  \n\r [1] Начать движение  \n\r [2] Нажать газ \n\r [3] Нажать тормоз  \n\r" +
                " [4] Повернуть руль вправо \n\r [5] Повернуть руль влево  \n\r" +
                " [6] Включить/выключить фары  \n\r [7] Движение врерёд \n\r" +
            " [8] Задний ход  \n\r [9] Максимальная скорость и движение вперёд  \n\r [10] Остановить машину  \n\r\n\r" +
             " [11] Изменить силу нажатия,         сила нажатия = {6}     \n\r"+
             " [12] Изменить угол поворота руля,   угол поворота руля = {7}   ";

            string[] statusDrive = { "остановлен", "едет вперёд", "едет назад", "едет вперёд на максимальной скорости" };
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(information,name, speed, direction % 360, statusDrive[(int) status], remainder, isLight ? "включены" : "выключены", power, angle);
            Console.ReadKey();
        }

        private int Point(int maxValue)
        {
            int a=0;
            string point="";
            bool isCorrect = false;
            while (!isCorrect)
                    {
                        Console.Write(" ваш выбор = ");
                        point = Console.ReadLine().Trim();
                        isCorrect = int.TryParse(point, out a) && (a >= 1) && (a <= maxValue );
                        if (!isCorrect)
                        {
                            Console.WriteLine(" Сделайте правильный выбор ");
                        }
                    }
            return a;
        }

        private void EndWork()
        {
            Console.WriteLine("Завершение работы программы");
            
        }
            
        
    }
}
