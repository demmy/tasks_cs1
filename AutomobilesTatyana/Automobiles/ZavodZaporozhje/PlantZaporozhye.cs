using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDetails;

namespace ZavodZaporozhye
{
    class PlantZaporozhye : IPlant
    {
        public string ProgrammerName
        {
            get { return "Tatyana"; }
        }

        public IEngine CreateEngine()
        {
            return new EngineZaporozhye();
        }

        public ITank CreateTank()
        {
            return new TankZaporozhye(); 
        }

        public ISteeringWheel CreateSteeringWheel()
        {
            return new SteeringWheelZaporozhye();
        }

        public ITransmission CreateTransmission()
        {
            return new TransmissionZaporozhye();
        }

        public IPedal CreatePedalGas()
        {
            return new PedalGasZ();
        }

        public IPedal CreatePedalBreak()
        {
            return new PedalBreakZ();

        }
        

        public IControlPanel CreateControlPanel()
        {
            return new ControlPanelZaporozhye();
        }


       
    }
}
