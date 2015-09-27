using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Sergey.Interfaces;

namespace Patterns.Sergey.Models
{
    class Product:IProduct
    {
        public delegate void ProductArrivedHandler(object @this, ProductEventArgs eventArgs);

        private string _title;

        public string Title
        {
            get { return _title; }
        }

        public int Number { get; set; }
        public double Price { get; set; }
    }
}
