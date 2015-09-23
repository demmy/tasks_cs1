using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace Patterns.Taisiya
{
    enum Items1
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
        Chicken
    }
    enum Items2
    {
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

    class Shopping
    {
        public InternetShop Varus = new InternetShop("IVARUS");
        Random rand = new Random();
        private static System.Timers.Timer goodsTimer;

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            goodsTimer.Stop();
            Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);
            foreach (var it in Enum.GetValues(typeof(Items2)))
            {
                Varus.NewAddToShop(new Goods(it.ToString(), rand.Next(1, 101), rand.Next(1, 501), true));
            }
        }
        public void MakeShopping()
        {
            foreach (var it in Enum.GetValues(typeof(Items1)))
                Varus.AddToShop(new Goods(it.ToString(), rand.Next(1, 101), rand.Next(1, 501), true));
         
            Varus.AddToShop(new Goods(Items2.Turkey.ToString(), 0, 0, false));
            Varus.AddToShop(new Goods(Items2.Basilic.ToString(), 0, 0, false));
            Varus.AddToShop(new Goods(Items2.Cup.ToString(), 0, 0, false));

            goodsTimer = new System.Timers.Timer(10000);
            goodsTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            goodsTimer.Start();

            #region Menu Swither
            string userInput;

            do
            {
                userInput = DisplayMenu();
                switch (userInput)            
                {
                    case "A": Varus.ShowGoods();
                        break;

                    case "B":
                        {
                            Console.WriteLine("Enter number of the product:");
                            int item = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter quantity:");
                            double q = Convert.ToDouble(Console.ReadLine());

                            if (!Varus.GoodsList.ElementAt(item - 1).Status)
                            {
                                Varus.AddToFavourites(Varus.GoodsList.ElementAt(item - 1));
                                Console.WriteLine("Sorry, this item is not available now. It is added to your list of favourites. You'll be informed about its status.");
                            }
                            else
                                if (Varus.GoodsList.ElementAt(item - 1).Quantity < q)
                                {
                                    Varus.AddToBasket(Varus.GoodsList.ElementAt(item - 1), Varus.GoodsList.ElementAt(item - 1).Quantity);
                                    Console.WriteLine("Sorry, there's no such quantity of this item. {0} of {1} is added to your basket.", 
                                        Varus.GoodsList.ElementAt(item - 1).Quantity, Varus.GoodsList.ElementAt(item - 1).Title);
                                }
                                else
                                    Varus.AddToBasket(Varus.GoodsList.ElementAt(item - 1), q);

                            if (q >= Varus.GoodsList.ElementAt(item - 1).Quantity)
                                Varus.GoodsList.ElementAt(item - 1).Status = false;
                        }
                        break;

                    case "C":
                        {
                            Console.WriteLine("Enter number of the product:");
                            int item = Convert.ToInt32(Console.ReadLine());                            
                            Varus.AddToFavourites(Varus.GoodsList.ElementAt(item-1));
                        }
                        break;

                    case "D":
                        {
                            Console.WriteLine("Enter number of the product:");
                            int item = Convert.ToInt32(Console.ReadLine());
                            Varus.RemoveFromBasket(Varus.BasketList.Keys.ElementAt(item - 1));
                        }
                        break;

                    case "E":
                        {
                            Console.WriteLine("Enter number of the product:");
                            int item = Convert.ToInt32(Console.ReadLine());
                            Varus.RemoveFromFavourites(Varus.FavouritesList.ElementAt(item - 1));
                        }
                        break;

                    case "F":
                        {
                            Console.WriteLine("Enter number of the product:");
                            string item = Console.ReadLine();
                            Varus.IsGoodsAvailable(item);
                        }
                        break;

                    case "G": Varus.ShowBasket();
                        break;

                    case "H": Varus.ShowFavourites();
                        break;

                    case "I": Varus.Buy();
                        break;

                    case "J": Console.WriteLine("Thank you for visiting!");
                        break;

                    default: Console.WriteLine("Please, enter the right key.");
                        break;
                }
            }
            while (userInput != "J");
            #endregion
        }

        public static string DisplayMenu()
        {
            Console.WriteLine("\n============================================================================\n");
            Console.WriteLine("A. List of goods");
            Console.WriteLine("B. Add to basket (enter a number of the item)");
            Console.WriteLine("C. Add to favourites (enter a number of the item)");
            Console.WriteLine("D. Remove from basket (enter a number of the item)");
            Console.WriteLine("E. Remove from favourites (enter a number of the item)");
            Console.WriteLine("F. Check the product (enter its title)");
            Console.WriteLine("G. My basket");
            Console.WriteLine("H. My favourites");
            Console.WriteLine("I. Buy");
            Console.WriteLine("J. Exit");
            Console.WriteLine("\n============================================================================\n");

            var result = Console.ReadLine();
            return result;
        }
    }
}
