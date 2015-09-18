using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Automobiles
{
    public enum Lights
    {
        Off, Far, Close
    }
    public interface ICar
    {
        void PressAccelerator(int pressurePower);
        void PressBrakes(int pressurePower);
        void RotateSteeringWheelRight(int angle);
        void RotateSteeringWheelLeft(int angle);
        void TurnOnFarLights();
        void TurnOnCloseLights();
        void TurnOffLights();
    }
}