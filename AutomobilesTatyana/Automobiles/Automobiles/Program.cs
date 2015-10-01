﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
            Menu menu = new Menu(plants);
            menu.MainMenu();
            Console.WriteLine("Нажмите любую клавишу ");
            Console.ReadKey();

        }
    }
}
