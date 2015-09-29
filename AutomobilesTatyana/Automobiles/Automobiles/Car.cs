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
        double direction=0;
        double power=0;
        double angle=0;
        bool isLight=false;
        StatusTransmission status = StatusTransmission.Stop;

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
            speed = PedalBreak.Speed(power, Transmission);

        }

        public void PressGas(double power)
        {
            speed = PedalGas.Speed(power, Transmission);
            
        }

        public void TurnSteeringWheelRight(double angle)
        {
            angle = SteeringWheel.AngleTurnWheel(angle);
        }

        public void TurnSteeringWheelLeft(double angle)
        {
            angle = SteeringWheel.AngleTurnWheel(angle);
        }

        public void OnOffHeadLight()
        {
            isLight = !isLight;
        }

        public bool IsLight
        {
            get
            {
                return isLight;
            }
            
        }

        public StatusTransmission Status { 
            get
            { 
                return status;
            }
            set 
            { 
                status = value; 
            }
          }

        public double Speed()
        {
            return speed;

        }

        public double Direction()
        {
            return angle;
        }

        public double RemainderFuel()
        {
            return Tank.Remainder;
        }





        
    }
}
