using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles.Interfaces
{
    interface IDashboard
    {
        void ShowFuelQuantity(double currentVolumetricCapability);
        void ShowDirection (int angleDegree);
        void ShowSpeed(int currentSpeed);
        void ShowLightsStatus(bool status);
    }
}
