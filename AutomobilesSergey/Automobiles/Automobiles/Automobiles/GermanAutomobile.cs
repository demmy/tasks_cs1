using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panels;

namespace Automobiles.Automobiles
{
    enum GerModels
    {
        BMW,
        Audi,
        Mercedes,
        Porsche
    }
    class GermanAutomobile:Automobile<GerModels>
    {
        public GermanAutomobile(string title, GerModels model) : base(title, model)
        {
            Panel = new GermanPanel();
        }
    }
}
