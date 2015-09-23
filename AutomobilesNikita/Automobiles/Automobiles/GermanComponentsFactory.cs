using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComponentsInterfaces;
using GermanComponents;

namespace Automobiles
{
    public class GermanComponentsFactory : IComponentsFactory
    {
        public GermanComponentsFactory()
        {
        }

        public IEngine CreateEngine()
        {
            return new Engine();
        }

        public ISteeringWheel CreateWheel()
        {
            return new SteeringWheel();
        }

        public IGasolineTank CreateTank()
        {
            return new GasolineTank();
        }

        public IPedals CreatePedals()
        {
            return new Pedals();
        }

        public IControlPanel CeratePanel()
        {
            return new ControlPanel();
        }

        public ITransmission CreateTransmission()
        {
            return new Transmission();
        }
    }
}