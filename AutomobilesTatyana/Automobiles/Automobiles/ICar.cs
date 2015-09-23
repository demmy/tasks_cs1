using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles
{
    interface ICar
    {
        string Name { get; }

         void PressBreak(double power);

         void PressGas(double power);
         void TurnSteeringWheelRight(double angle);
         void TurnSteeringWheelLeft(double angle);
         void OnHeadLight();
         void OffHeadLight();
         double Speed();
         double Direction();
         double RemainderFuel();

    }
}
            
