using System;
using System.Linq;
using Patterns.Sergey.Interfaces;
using Patterns.Sergey.Models;

namespace Patterns.Sergey
{
    static partial class UserDialog
    {
        private static void DisplayProducts(IShop shop)
        {
            foreach (IProduct product in shop.Products)
            {
                Console.WriteLine("{0} {1} {2}$", product.Title, product.Number, product.Price);
            }
        }

        private static void AddToBasket(IShop shop)
        {
            Console.WriteLine("Enter title product you wanna buy");
            string product = Console.ReadLine();
            var pr = shop.Products.First(prod => prod.Title == product);

            if (pr != null)
            {
                Console.WriteLine("Enter their number");
                int numb = int.Parse(Console.ReadLine());
                shop.AddToBasket(new Product(pr.Title, numb, pr.Price));
            }
            
        }

        private static void ReturnProduct(IShop shop)
        {
            Console.WriteLine("Enter title product you wanna return");
            string product = Console.ReadLine();
            var pr = shop.Basket.First(prod => prod.Title == product);
            shop.RemoveFromBasket(pr);
        }

        private static void ClearBasket(IShop shop)
        {
            shop.ClearBasket();
        }

        private static void SubscribeOnProduct(IShop shop)
        {
            Console.WriteLine("Enter title product you wanna wait for");
            string product = Console.ReadLine();
            var pr = shop.Products.First(prod => prod.Title == product);
            shop.Subscribe(pr);
        }

        private static void UnSubscribeFromProduct(IShop shop)
        {
            Console.WriteLine("Enter title product you wanna stop wait for");
            string product = Console.ReadLine();
            var pr = shop.Products.First(prod => prod.Title == product);
            shop.Subscribe(pr);
        }
    }
}
