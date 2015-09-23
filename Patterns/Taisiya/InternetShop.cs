using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Taisiya
{
    public delegate void NewGoods();

    class InternetShop : IInternetShop
    {
        private string title;
        private List<IGoods> goodsList = new List<IGoods>();
        public event NewGoods goodsArrived;
        private Dictionary<IGoods, double> Basket = new Dictionary<IGoods, double>();
        private List<IGoods> Favourites = new List<IGoods>();
        private double Bill;

        public InternetShop(string title)
        {
            this.title = title;
        }

        public string Title
        {
            get { return title; }
        }

        public List<IGoods> GoodsList
        {
            get { return goodsList; }
        }

        public Dictionary<IGoods, double> BasketList
        {
            get { return Basket; }
        }

        public List<IGoods> FavouritesList
        {
            get { return Favourites; }
        }

        public void AddToShop(IGoods product)
        {
            List<IGoods> tempList = new List<IGoods>();
            tempList.AddRange(goodsList);

            if (goodsList.Count > 0)
                foreach (var t in tempList)
                {
                    if (t.Title == product.Title && !t.Status)
                        goodsList.RemoveAt(tempList.IndexOf(t));
                }
            
                goodsList.Add(product);
        }


        public void NewAddToShop(IGoods product)
        {
            List<IGoods> tempList = new List<IGoods>();
            tempList.AddRange(Favourites);

            AddToShop(product);

            foreach (var t in tempList)
                if (t.Title == product.Title && product.Status)
                {
                    goodsArrived += new NewGoods(Handler);
                    RemoveFromFavourites(t);
                    AddToBasket(product, 1);                  
                }

           NewGoodsArrived();    
        }

        public void NewGoodsArrived()
        {
            if (goodsArrived != null)
            {
                goodsArrived();
            }
            goodsArrived -= new NewGoods(Handler);
        }

        public static void Handler()
        {
            Console.WriteLine("Product is available!");
        }
        
        public void ShowGoods()
        { 
            int i = 1;

            foreach (var g in goodsList)
            {
                Console.WriteLine(i + ". Item: {0}  -  {1} USD  -  Quantity: {2}  -  Available: {3}", g.Title, g.Price, g.Quantity, g.Status);
                i++;
            }
        }

        public void IsGoodsAvailable(string product)
        {
            foreach (var g in goodsList)
            {
                if (product == g.Title && g.Status)
                {
                    Console.WriteLine("Product {0} is available with price {1}", g.Title, g.Price);
                }
            }
        }

        public void AddToBasket(IGoods product, double quantity)
        {
            Basket.Add(product, quantity);

            Bill += product.Price * quantity;
        }

        public void RemoveFromBasket(IGoods product)
        {
            Bill -= product.Price * Basket[product];
            Basket.Remove(product);
        }

        public void AddToFavourites(IGoods product)
        {
            Favourites.Add(product);
        }

        public void RemoveFromFavourites(IGoods product)
        {
            Favourites.Remove(product);
        }

        public void Buy()
        {            
            foreach (var g in goodsList)
                foreach (var b in Basket)
                {
                    if (g == b.Key)
                        g.Quantity -= b.Value;
                }

                Console.WriteLine("Your bill is {0} USD. You've successfully bought goods in {1}! Thank you!", Bill, title);
        }

        public void ShowBasket()
        {
            int i = 1;

            foreach (var b in Basket)
            {
                Console.WriteLine(i + ". Item: {0}  -  Total: {1} USD  -  Quantity: {2} ", b.Key.Title, b.Key.Price*b.Value, b.Value);
                i++;
            }
            Console.WriteLine("\nYour bill is {0} USD.", Bill, title);
        }

        public void ShowFavourites()
        {
            int i = 1;

            foreach (var f in Favourites)
            {
                Console.WriteLine(i + ". Item: {0}  -  Available: {1}", f.Title, f.Status);
                i++;
            }
        }
    }
}
