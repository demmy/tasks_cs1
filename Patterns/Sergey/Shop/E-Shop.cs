using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Sergey.Interfaces;

namespace Patterns.Sergey.Shop
{
    class EShop: IShop
    {
        public delegate void ProductArrivedHandler(object @this, ProductEventArgs eventArgs);

        private List<IProduct> products;
        private readonly string _title;

        public EShop(string title)
        {
            _title = title;
        }
        public string Title {
            get { return _title; }
        }
        public event ProductArrivedHandler GoodsArrived;
    }
}
