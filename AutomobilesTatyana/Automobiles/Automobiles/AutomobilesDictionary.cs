using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Automobiles
{
    class AutomobilesDictionary: KeyedCollection<string, ICar>
    {
        protected override string GetKeyForItem(ICar item)
        {
            return item.Name;
        }
    }
}
