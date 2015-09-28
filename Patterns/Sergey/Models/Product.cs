using System.Collections.Generic;
using Patterns.Sergey.Interfaces;

namespace Patterns.Sergey.Models
{
    class Product: IProduct
    {
        private readonly string _title;
        private int _number;

        private List<IShop> _observers;// Observers
        public Product(string title, int num, double price)
        {
            _title = title;
            Number = num;
            Price = price;
            _observers = new List<IShop>();
        }

        public string Title
        {
            get { return _title; }
        }

        public int Number
        {
            get { return _number; }
            set
            {
                _number = value;
                Notify();
            }
        }

        public double Price { get; set; }
        public event ProductArrivedHandler Update;
        public void Subscribe(IShop shop)
        {
            _observers.Add(shop);
        }

        public void Unsubscribe(IShop shop)
        {
            _observers.Remove(shop);
        }

        public void Notify()
        {
            if (Update == null) return;
            foreach (IShop observer in _observers)
            {
                Update(this, new ProductEventArgs(observer.Title));
            }
        }
    }
}
