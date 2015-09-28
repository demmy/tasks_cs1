using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Sergey;
using Patterns.Sergey.Interfaces;
using Patterns.Sergey.Models;
using Patterns.Sergey.Shop;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length > 0)
                {
                    Console.WriteLine("Argument: {0}", args[0]);
                    switch (args[0])
                    {
                        case "Tatyana":
                            MainTatyana();
                            break;
                        case "Taisiya":
                            MainTaisiya();
                            break;
                        case "Nikita":
                            MainNikita();
                            break;
                        case "Sergey":
                            MainSergey();
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Not all code implemented. Problem: {0}", e.Message);
                Console.WriteLine("Details: {0}", e.ToString());
            }
        }

        static void CustomerMenu(IShop shop)
        {
            Console.WriteLine("Hey there - you have visited e-shop {0}, what do wanna do?", shop.Title);
            while (true)
            {
                var command = UserDialog.Dialog();
                command(shop);
            }
        }

        enum Food
        {
            Apple,
            Tomato,
            Potato,
            IceCream,
            Butter,
            Cheese,
            Milk,
            Water,
            Juice,
            Tea,
            Coffee,
            Cake,
            Pie,
            Chocolate,
            Cookies,
            Bread,
            Beef,
            Pork,
            Chicken,
            Turkey,
            Peach,
            Grape,
            Basilic,
            Rice,
            Flour,
            Sugar,
            Plate,
            Glass,
            Cup,
            Jogurt,
            Fish,
            Souce,
            Doughnut,
            Quark
        }

        static void MainSergey()
        {
            #region Observer

            Random rnd = new Random();
            List<IProduct> products = Enum.GetNames(typeof (Food)).Select(food => new Product(food, rnd.Next(10), rnd.NextDouble()*40)).Cast<IProduct>().ToList();

            IShop shop = new EShop("rozetka", products);
            shop.ProductsArrived += (@this, args) =>
            {
                var observedProduct = @this as IProduct;
                if(observedProduct == null) return;
                Console.WriteLine("The shop {0} has {2} {1}(s) by {3}$ for one", args.ShopTitle, observedProduct.Title, observedProduct.Number, observedProduct.Price);
            };
            CustomerMenu(shop);
            #endregion
        }

        static void MainTaisiya()
        {
            #region Observer
            #endregion
        }

        static void MainNikita()
        {
            #region Observer
            #endregion
        }

        static void MainTatyana()
        {
            #region Observer
            #endregion
        }
    }
}
