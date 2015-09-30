using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDetails
{
    public  interface IControlPanel
    {
        double Speed { get; }
        double Direction { get; }
        double RemainderFuel { get; }
    }
}
