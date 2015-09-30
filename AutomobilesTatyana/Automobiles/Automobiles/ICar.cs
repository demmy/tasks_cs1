using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDetails;

namespace Automobiles
{
    interface ICar
    {
        string Name { get; }
        
         
         void PressGas(double power);
         void PressBreak(double power);
         void TurnSteeringWheelRight(double angle);
         void TurnSteeringWheelLeft(double angle);
         void OnOffHeadLight();
         bool IsLight { get; }
         StatusTransmission Status { get; set; }
         double Speed();
         double Direction();
         double RemainderFuel();

        

    }
}
            
