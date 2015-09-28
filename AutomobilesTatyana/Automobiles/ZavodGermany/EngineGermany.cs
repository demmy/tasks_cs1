using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDetails;

namespace ZavodGermany
{
    class EngineGermany : IEngine
    {
        double number = 0.5;
        public double CountFuelOnKilometer(double speed)
        {
            return number * speed;
        }
        public double CountFuelOnInHour(double speed)
        {
            return CountFuelOnKilometer(speed) * speed;
        }

        
    }
}
