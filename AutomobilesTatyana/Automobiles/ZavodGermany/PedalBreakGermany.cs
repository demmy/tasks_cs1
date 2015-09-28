using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDetails;

namespace ZavodGermany
{
    class PedalBreakGermany : IPedal
    {
        double number = 5;
        public double Speed(double power, ITransmission transmission)
        {
            double speed = 0;
            double koeficient = 0;
            switch (transmission.Status)
            {
                case StatusTransmission.Stop:
                    break;
                case StatusTransmission.Forward:
                case StatusTransmission.Ago:
                    koeficient = 1;
                    break;
                case StatusTransmission.MaxSpeed:
                    koeficient = 2;
                    break;
                default:
                    break;

            }

            speed = number * koeficient / power;
            return speed;
        }
    }
}
