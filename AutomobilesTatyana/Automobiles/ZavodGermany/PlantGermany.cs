using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDetails;

namespace ZavodGermany
{
    class PlantGermany : IPlant
    {
        public string ProgrammerName
        {
            get { return "Tatyana"; }
        }

        public IEngine CreateEngine()
        {
            return new EngineGermany();
        }

        public ITank CreateTank()
        {
            return new TankGermany(); 
        }

        public ISteeringWheel CreateSteeringWheel()
        {
            return new SteeringWheelGermany();
        }

        public ITransmission CreateTransmission()
        {
            return new TransmissionGermany();
        }

        public IPedal CreatePedalGas()
        {
            return new PedalGasGermany();
        }

        public IPedal CreatePedalBreak()
        {
            return new PedalBreakGermany();

        }
        

        public IControlPanel CreateControlPanel()
        {
            return new ControlPanelGermany();
        }


       
    }
}
