using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComponentsInterfaces;
using UkrainianComponents;

namespace Automobiles
{
    public class UkrainianComponentsFactory : IComponentsFactory
    {
        public UkrainianComponentsFactory()
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