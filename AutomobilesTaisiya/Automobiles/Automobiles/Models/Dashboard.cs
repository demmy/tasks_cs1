using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles.Models
{
    class Dashboard: Interfaces.IDashboard
    {
        public void ShowFuelQuantity(double currentVolumetricCapability)
        {
            Console.WriteLine("Residual fuel: {0}", currentVolumetricCapability);
        }

        public void ShowDirection(int angleDegree)
        {
            if (angleDegree > 0)
                Console.WriteLine("Direction: {0} degrees on the left", angleDegree);
            if (angleDegree < 0)
                Console.WriteLine("Direction: {0} degrees on the right", angleDegree*(-1));
            if (angleDegree == 0)
                Console.WriteLine("Your car is moving straight.");
        }

        public void ShowSpeed(int currentSpeed)
        {
            Console.WriteLine("Current speed: {0}", currentSpeed);
        }

        public void ShowLightsStatus(bool status)
        {
            if (status)
                Console.WriteLine("Lights are turned on now.");
            else
                Console.WriteLine("Lights are turned off now.");

        }

    }
}
