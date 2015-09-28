using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using InterfacesDetails;

namespace Automobiles
{
    class PlantsDictionary : KeyedCollection<string, IPlant>
    {
        protected override string GetKeyForItem(IPlant item)
        {
            return item.NameOfPlant;
        }
    }
}
