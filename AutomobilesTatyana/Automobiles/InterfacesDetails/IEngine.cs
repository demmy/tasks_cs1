using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDetails
{
    public interface IEngine
    {
        double CountFuelOnInHour(double speed);
        double CountFuelOnKilometer(double speed);
    }
}
