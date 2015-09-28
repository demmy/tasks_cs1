using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDetails;

namespace ZavodZaporozhye
{
    class SteeringWheelZaporozhye: ISteeringWheel
    {
        double number = 0.1;
        public double Luft
        {
            get { return 10; }
        }

        public double AngleTurnWheel(double angle)
        {
            double angle1 = (angle<Luft?0:angle-Luft)*number;
            return angle1;
        }
    }
}
