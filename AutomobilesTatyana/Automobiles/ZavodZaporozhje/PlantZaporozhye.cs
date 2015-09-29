using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDetails;

namespace ZavodZaporozhye
{
    public class PlantZaporozhye : IPlant
    {
        public string ProgrammerName
        {
            get { return "Tatyana"; }
        }

        public string NameOfPlant
        {
            get { return "Zaporozhye";  }
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
            return new PedalGasZaporozhye();
        }

        public IPedal CreatePedalBreak()
        {
            return new PedalBreakZaporozhye();

        }

        public IControlPanelInner CreateControlPanel()
        {
            return new ControlPanelZaporozhye();
            
        }
    }
}
