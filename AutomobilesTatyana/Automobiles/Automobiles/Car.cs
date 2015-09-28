using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDetails;

namespace Automobiles
{
    class Car : ICar
    {
        string name;
        double speed=0;
        double direction;
        double power=0;
        double angle=0;

        public IEngine Engine { get; set; }
        public ITank Tank { get; set; }
        public ISteeringWheel SteeringWheel { get; set; }
        public ITransmission Transmission { get; set; }
        public IPedal PedalGas { get; set; }
        public IPedal PedalBreak { get; set; }

        IControlPanelInner ControlPanelInner { get; set; }
        public IControlPanel ControlPanel   {  get; set; }
        public Car(string name1)
        {
            name = name1;
        }
        public string Name
        {
            get { return name; }
        }

        public void PressBreak(double power)
        {
            throw new NotImplementedException();
        }

        public void PressGas(double power)
        {
            throw new NotImplementedException();
        }

        public void TurnSteeringWheelRight(double angle)
        {
            throw new NotImplementedException();
        }

        public void TurnSteeringWheelLeft(double angle)
        {
            throw new NotImplementedException();
        }

        public void OnHeadLight()
        {
            throw new NotImplementedException();
        }

        public void OffHeadLight()
        {
            throw new NotImplementedException();
        }

        public double Speed()
        {
            throw new NotImplementedException();
        }

        public double Direction()
        {
            throw new NotImplementedException();
        }

        public double RemainderFuel()
        {
            throw new NotImplementedException();
        }
    }
}
