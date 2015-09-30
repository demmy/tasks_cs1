﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDetails;

namespace ZavodGermany
{
    public class PlantGermany : IPlant
    {
        public string ProgrammerName
        {
            get { return "Tatyana"; }
        }

        public string NameOfPlant
        {
            get { return "GermanyPlant"; }
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

        public IControlPanelInner CreateControlPanel()
        {
            return new ControlPanelGermany();
            
        }
    }
}
