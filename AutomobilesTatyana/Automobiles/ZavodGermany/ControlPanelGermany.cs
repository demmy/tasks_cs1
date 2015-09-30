using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDetails;

namespace ZavodGermany
{
    class ControlPanelGermany : IControlPanelInner
    {

        public double Speed { get; set; }

        public double Direction { get; set; }

        public double RemainderFuel { get; set; }
        
    }
}
