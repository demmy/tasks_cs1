using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles.Interfaces
{
    interface IComponents
    {
        IMotor CreateMotor();
        IPedal CreatePedal(int treadleEffort);
        IGearBox CreateGearBox(int GeraNubmer);
        ISteeringWheel CreateSteeringWheel(int angleDegree);
        IFuelTank CreateFuelTank(int volumetricCapability);
        IDashboard CreateDashboard();
    }
}
