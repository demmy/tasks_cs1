using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDetails
{
     public interface IPedal
    {
        double Speed(double power, ITransmission transmission);
    }
}
