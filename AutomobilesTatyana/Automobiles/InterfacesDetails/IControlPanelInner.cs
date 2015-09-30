using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDetails
{
   public  interface IControlPanelInner : IControlPanel
    {
            double Speed { get; set; }
            double Direction { get; set; }
            double RemainderFuel { get; set; }

        
    }
}
