using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Automobiles
{
    public class CarEventArgs : EventArgs
    {
        private string _data;

        public CarEventArgs(string data)
        {
            _data = data;
        }

        public string Data
        {
            get { return _data; }
        }
    }

    public enum Lights
    {
        Off, Far, Close
    }
    public interface ICar
    {
        event EventHandler<CarEventArgs> FuelEnded;
        event EventHandler<CarEventArgs> CarStopped;

        string Name { get; set; }
        double Fuel { get; set; }
        int Direction { get; set; }
        Lights Lights { get; set; }
        int Speed { get; set; }

        void RefreshCarState(object sender, EventArgs eventArgs);
        void PressAccelerator(int pressurePower);
        void PressBrakes(int pressurePower);
        void RotateSteeringWheelRight(int angle);
        void RotateSteeringWheelLeft(int angle);
        void TurnOnFarLights();
        void TurnOnCloseLights();
        void TurnOffLights();
    }
}