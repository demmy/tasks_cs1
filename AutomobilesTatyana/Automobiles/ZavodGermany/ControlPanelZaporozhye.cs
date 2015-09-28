using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDetails;

namespace ZavodGermany
{
    class ControlPanelGermany : IControlPanel
    {
        double speed;
        double way;
        double remainder;
        double direction;
        public double Speed
        {
            get { return speed; }
        }

        public double Way
        {
            get { return way; }
        }

        public double RemainderFuel
        {
            get { return remainder; }
        }

        public double Direction
        {
            get { return direction; }
        }
    }
}
