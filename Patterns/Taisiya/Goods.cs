using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Taisiya
{

    class Goods : IGoods
    {
        private string title;
        private double price;
        private double quantity;
        private bool status;

        public Goods(string title, double price, double quantity, bool status)
        {
            this.title = title;
            this.price = price;
            this.quantity = quantity;
            this.status = status;
        }

        public string Title
        {
            get { return title; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
