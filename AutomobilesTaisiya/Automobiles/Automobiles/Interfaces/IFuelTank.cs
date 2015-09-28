using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles.Interfaces
{
    interface IFuelTank
    {
        double VolumetricCapability { get; set; }
        double CurrentVolumetricCapability { get; set; }
    }
}
