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
            AutomobilesDictionary automobiles = new AutomobilesDictionary();
            string mainMenu = " [1] Создать автомобиль \n\r\n\r [2] Покататься \n\r\n\r [3] Выход  \n\r\n\r Ваш выбор = ";
            string choose ="0";
            string name = "";
            Console.WriteLine();
            Console.WriteLine("[1] Создать автомобиль ");
            Console.WriteLine();
            Console.WriteLine("[2] Покататься ");
            Console.WriteLine();
            Console.WriteLine("[3] Выход ");
            Console.WriteLine();
            //Console.Write(" Ваш выбор = ");
            
            //choose = Console.ReadLine().Trim();
            //Console.WriteLine();
            //Console.Write(mainMenu);
            //choose = Console.ReadLine().Trim();
            //Console.Clear();
            //switch (choose)
            //{
            //    case "1":
            //        Console.WriteLine("Введите имя автомобиля");
            //        name = Console.ReadLine();
            //        Console.WriteLine("Автомобиль какого именно завода мы создаём");
            //        break;
            //    case "2":
            //        Console.WriteLine("Выберите автомобиль");
            //        foreach (var n in automobiles)
            //            Console.WriteLine(n.Name);
            //        break;
            //    case "3":
            //        Console.WriteLine("Завершение работы программы");
            //        break;
            //    default:
            //        Console.WriteLine("Неправильный выбор");
            //        break;
            //}
            Console.ReadKey();

        }
    }
}
