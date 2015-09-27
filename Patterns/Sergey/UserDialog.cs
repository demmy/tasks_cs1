using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Sergey.Interfaces;

namespace Patterns.Sergey
{
    static partial class UserDialog
    {
        #region Commands

        private static readonly Dictionary<string, Tuple<string, Action<IShop>>> Commands = new Dictionary
            <string, Tuple<string, Action<IShop>>>
        {
            {
                "-pr",
                new Tuple<string, Action<IShop>>("Display list of products", DisplayProducts)
            },
            {
                "-buy",
                new Tuple<string, Action<IShop>>("Add product to basket", AddToBasket)
            },
            {
                "-sbuy",
                new Tuple<string, Action<IShop>>("Return Basket product", ReturnProduct)
            },
            {
                "-clr",
                new Tuple<string, Action<IShop>>("Clear Basket", ClearBasket)
            },
            {
                "-obs",
                new Tuple<string, Action<IShop>>("Wait for this product", SubscribeOnProduct)
            },
            {
                "-sobs",
                new Tuple<string, Action<IShop>>("Stop waiting for product", UnSubscribeFromProduct)
            },
            {
                "-fin",
                new Tuple<string, Action<IShop>>("Buy products in Basket", (shop) => { shop.Buy();})
            },
            {
                "-ex",
                new Tuple<string, Action<IShop>>("Clear Basket and go away without buying", (shop) =>
                {
                    ClearBasket(shop);
                    Console.WriteLine("Thank you");
                    Environment.Exit(0);
                })
            }
        };

        #endregion

        public static Action<IShop> Dialog()
        {
            foreach (var command in Commands)
                Console.WriteLine("{0}: {1}", command.Key, command.Value);
            
   
            var result = Console.ReadLine();
            if (result != null && Commands.ContainsKey(result))
                return Commands[result].Item2;
            return (shop) => { Console.WriteLine("Sorry there is no such command recognised for {0}", shop.Title); };
        }
    }
}
