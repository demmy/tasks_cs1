using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDetails
{
     public interface ISteeringWheel
    {
        double Luft { get; }
        double AngleTurnWheel(double angle);
    }
}
