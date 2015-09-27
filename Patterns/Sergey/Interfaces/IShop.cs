using System.Collections.Generic;

namespace Patterns.Sergey.Interfaces
{
    public delegate void ProductArrivedHandler(object @this, ProductEventArgs arg);
    interface IShop
    {
        event ProductArrivedHandler ProductsArrived;

        string Title { get; }
        IEnumerable<IProduct> Products { get; }
        IEnumerable<IProduct> Basket { get; }
        void Income(IProduct product, int num);
        void Subscribe(IProduct product);
        void Unsubscribe(IProduct product);
        void Notify(IProduct product, ProductEventArgs arg);
        void ClearBasket();
        void AddToBasket(IProduct product);
        void RemoveFromBasket(IProduct product);
        void Buy();
    }

    public class ProductEventArgs
    {
        public ProductEventArgs(string name)
        {
            ShopTitle = name;
        }

        public string ShopTitle { get; private set; }
    }
}
