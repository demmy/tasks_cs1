using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles
{
    enum Lights
    {
        Far, Close, Off
    }
    interface ICar
    {
        
        string Name { get; set; }
        int Fuel { get; set; }
        int Direction { get; set; }
        Lights Lights { get; set; }
        int Speed { get; set; }

        void PressAccelerator(int pressurePower);
        void PressBrakes(int pressurePower);
        void RotateSteeringWheelRight(int angle);
        void RotateSteeringWheelLeft(int angle);
        void TurnOnFarLights();
        void TurnOnCloseLights();
        void TurnOffLights();
    }
}
