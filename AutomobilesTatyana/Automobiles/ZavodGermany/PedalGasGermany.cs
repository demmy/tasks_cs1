using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDetails;

namespace ZavodGermany
{
    class PedalGasGermany : IPedal
    {
        double number = 5;
           

        public double Number
        {
            get { return number; }
        }

        public double SpeedKoefficient(double power)
        {
            return power * 2;
        }
    }
}
