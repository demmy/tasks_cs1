using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Sergey.Shop;

namespace Patterns.Sergey.Interfaces
{
    public class ProductEventArgs
    {
        public ProductEventArgs(int num, string name)
        {
            Name = name;
            Number = num;
        }

        public string Name { get; private set; }
        public int Number { get; private set; }
    }

    

    interface IShop
    {
        string Title { get; }
        event EShop.ProductArrivedHandler GoodsArrived;
    }
}
