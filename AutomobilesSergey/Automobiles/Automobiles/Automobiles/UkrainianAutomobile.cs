using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panels;

namespace Automobiles.Automobiles
{
    enum UkrModels
    {
        Zaz,
        Kraz,
        Uaz,
        Bogdan
    }
    class UkrainianAutomobile:Automobile<UkrModels>
    {
        public UkrainianAutomobile(string title, UkrModels model) : base(title, model)
        {
            Panel = new UkrainianPanel();
        }
    }
}
