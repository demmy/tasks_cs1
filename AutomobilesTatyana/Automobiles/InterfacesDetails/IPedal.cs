using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDetails
{
     public interface IPedal
     {
         double Number { get; } 
         double SpeedKoefficient(double power);
    }
}
