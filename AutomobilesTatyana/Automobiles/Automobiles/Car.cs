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

        IEngine engine;
        ITank tank;
        ISteeringWheel steeringWheel;
        ITransmission transmission;
        IPedal pedalGas;
        IPedal pedalBreak;
        IControlPanelInner controlPanel;

        
        public IControlPanel ControlPanel   {  get; set; }
        public Car(string name1, IEngine engine1, ITank tank1, ISteeringWheel steeringWheel1, ITransmission transmission1, 
                                              IPedal pedalGas1, IPedal pedalBreak1, IControlPanelInner controlPanel1  )
        {
            name = name1;
            engine = engine1;
            tank = tank1;
            steeringWheel = steeringWheel1;
            transmission = transmission1;
            pedalGas = pedalGas1;
            pedalBreak = pedalBreak1;
            controlPanel = controlPanel1;
        }

        public string Name
        {
            get { return name; }
        }

        public void PressBreak(double power)
        {
           // speed = pedalBreak.Speed(power, transmission);

        }

        public void PressGas(double power)
        {
           // speed = pedalGas.Speed(power, transmission);
            
        }

        public void TurnSteeringWheelRight(double angle)
        {
            angle = steeringWheel.AngleTurnWheel(angle);
        }

        public void TurnSteeringWheelLeft(double angle)
        {
            angle = steeringWheel.AngleTurnWheel(angle);
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
            return tank.Remainder;
        }





        
    }
}
