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
        double number = 5;


        public double Number
        {
            get { throw new NotImplementedException(); }
        }

        public double SpeedKoefficient(double power)
        {
            throw new NotImplementedException();
        }
    }
}
