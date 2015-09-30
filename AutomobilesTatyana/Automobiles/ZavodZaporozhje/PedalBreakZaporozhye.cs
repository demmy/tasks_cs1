using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDetails;

namespace ZavodZaporozhye
{
    class PedalBreakZaporozhye : IPedal
    {
        double number = 0.5;


        public double Number
        {
            get { return number; }
        }

        public double SpeedKoefficient(double power)
        {
            return 2 / power;
        }
    }
}
