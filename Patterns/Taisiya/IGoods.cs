using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Taisiya
{
    interface IGoods
    {
        string Title { get; }
        double Price { get; set; }
        double Quantity { get; set; }
        bool Status { get; set; }
    }
}
