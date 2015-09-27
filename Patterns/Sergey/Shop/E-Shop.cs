using System;
using System.Collections.Generic;
using System.Threading;
using Patterns.Sergey.Interfaces;

namespace Patterns.Sergey.Shop
{
    class EShop: IShop, IDisposable
    {        
        private List<IProduct> _storeProducts;
        private List<IProduct> _observedProducts;// Observers
        private List<IProduct> _basket;

        private bool _disposed;
        private readonly Timer _timer;
        private readonly string _title;
        private double _moneySpent;

        public event ProductArrivedHandler ProductsArrived;

        public EShop(string title, IEnumerable<IProduct> products)
        {
            _title = title;
            _storeProducts.AddRange(products);
            _basket = new List<IProduct>();
            _observedProducts = new List<IProduct>();
            _timer = new Timer(NewInflow, this, 0, 10000);
        }
        public string Title {
            get { return _title; }
        }
        public IEnumerable<IProduct> Products
        {
            get { return _storeProducts; }
        }

        public IEnumerable<IProduct> Basket
        {
            get { return _basket; }
        }

        public void Income(IProduct product, int num)
        {
            _storeProducts.Find(x => x.Equals(product)).Number = num;
            if (_observedProducts.Contains(product))
                Notify(product, new ProductEventArgs(Title));
        }

        public void Subscribe(IProduct product)
        {
            _observedProducts.Add(product);
        }

        public void Unsubscribe(IProduct product)
        {
            _observedProducts.Remove(product);
        }

        public void Notify(IProduct product, ProductEventArgs arg)
        {
            if (ProductsArrived != null)
                ProductsArrived(product, arg);
        }

        public void ClearBasket()
        {
            _basket.Clear();
            _moneySpent = 0;
        }

        public void AddToBasket(IProduct product)
        {
            _basket.Add(product);
            _moneySpent += product.Number*product.Number;
        }

        public void RemoveFromBasket(IProduct product)
        {
            if (_basket.Contains(product))
            {
                _moneySpent -= product.Number*product.Price;
                _basket.Remove(product);
            }
        }

        public void Buy()
        {
            _moneySpent = 0;
        }

        private static void NewInflow(object source)
        {
            var shop = source as IShop;
            Random rnd = new Random();

            if (shop == null) return;

            foreach (var product in shop.Products)
                shop.Income(product, rnd.Next(12));
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                _timer.Dispose();
            }
            _storeProducts.Clear();
            _storeProducts = null;
            _observedProducts.Clear();
            _observedProducts = null;
            _basket.Clear();
            _basket = null;
            _disposed = true;
        }
    }
}
