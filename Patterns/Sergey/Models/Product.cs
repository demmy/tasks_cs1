using Patterns.Sergey.Interfaces;

namespace Patterns.Sergey.Models
{
    class Product: IProduct
    {
        private readonly string _title;

        public Product(string title, int num, double price)
        {
            _title = title;
            Number = num;
            Price = price;
        }

        public string Title
        {
            get { return _title; }
        }

        public int Number { get; set; }

        public double Price { get; set; }
    }
}
