using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDetails;
using ZavodZaporozhye;
using ZavodGermany;

namespace Automobiles
{
    class Program
    {   
        /// <summary>
        ///  При подключении новой библиотеки классов в которой поставляется набор компонентов автомобиля
        ///  нужно в коде программы добавить одну строку 
        ///  plant.Add(new NamePlant);
        ///  где NamePlant - имя класса в новой библиотеке классов, который реализует интерфейс IPlant
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            PlantsDictionary plants = new PlantsDictionary();
            plants.Add(new PlantZaporozhye());
            plants.Add(new PlantGermany());
            CarFactory factory=new CarFactory();
            Car car=(Car) factory.CreateCar("Example", new PlantGermany());

            
            Menu menu = new Menu(plants);

            menu.PrintStatusDrive(car.Name, 68.5,45,StatusTransmission.Forward,50,23,5,true);
           // menu.MainMenu();
            Console.WriteLine("Нажмите любую клавишу ");
            Console.ReadKey();

        }
    }
}
