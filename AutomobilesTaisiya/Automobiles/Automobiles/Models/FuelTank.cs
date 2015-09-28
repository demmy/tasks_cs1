using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles.Models
{
    class FuelTank: Interfaces.IFuelTank
    {
        public double VolumetricCapability  { get; set; }
        public double CurrentVolumetricCapability { get; set; }

        public FuelTank(double volumetricCapability)
        {
            VolumetricCapability = volumetricCapability;
            CurrentVolumetricCapability = VolumetricCapability;
        }
    }
}
