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
        bool isLight=false;
        bool isCanDrive = false;
        bool isForward = true;
        StatusTransmission status = StatusTransmission.Stop;

        IEngine engine;
        ITank tank;
        ISteeringWheel steeringWheel;
        ITransmission transmission;
        IPedal pedalGas;
        IPedal pedalBreak;
        IControlPanelInner controlPanel;


        public IControlPanel ControlPanel 
        { 
            get 
          {
            return controlPanel;
          } 
        }
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

        

        public void PressGas(double power)
        {
            if (isCanDrive)
            {
                speed = pedalGas.Number * pedalGas.SpeedKoefficient(power) * transmission.TransmissionStatusKoefficient;
                controlPanel.Speed = speed;
            }
            
        }

        public void PressBreak(double power)
        {
            if (isCanDrive)
            {
                speed = pedalBreak.Number * pedalBreak.SpeedKoefficient(power) * transmission.TransmissionStatusKoefficient;
                controlPanel.Speed = speed;
            }
        }

        public void TurnSteeringWheelRight(double angle)
        {
            if (isCanDrive)
            {
                direction-= steeringWheel.AngleTurnWheel(angle);
                while (direction < 0)
                {
                    direction += 360;
                }
                controlPanel.Direction = direction;
            }
        }

        public void TurnSteeringWheelLeft(double angle)
        {
            if (isCanDrive)
            {
                direction += steeringWheel.AngleTurnWheel(angle);
                direction %=  360;
                controlPanel.Direction = direction;
            }
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
                transmission.Status=value;
                if ((isForward && value == StatusTransmission.Ago) || 
                    (!isForward && (value == StatusTransmission.Ago || value==StatusTransmission.MaxSpeed)))
                {
                    direction += 180;
                    direction %= 360;
                    controlPanel.Direction = direction;
                }
                status = value;
                if (status != StatusTransmission.Stop)
                {
                    isCanDrive = true;
                }
                else
                {
                    isCanDrive = false;
                }
            }
          }

        public double Speed()
        {
            return speed;

        }

        public double Direction()
        {
            return direction;
        }

        public double RemainderFuel()
        {
            return tank.Remainder;
        }
    }
}
