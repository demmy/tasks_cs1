using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComponentsInterfaces;

namespace Automobiles
{
    public class GermanComponentsFactory : IComponentsFactory
    {
        public GermanComponentsFactory()
        {
        }

        public IEngine CreateEngine()
        {
            throw new NotImplementedException();
        }

        public ISteeringWheel CreateWheel()
        {
            throw new NotImplementedException();
        }

        public IGasolineTank CreateTank()
        {
            throw new NotImplementedException();
        }

        public IPedals CreatePedals()
        {
            throw new NotImplementedException();
        }

        public IControlPanel CeratePanel()
        {
            throw new NotImplementedException();
        }

        public ITransmission CreateTransmission()
        {
            throw new NotImplementedException();
        }
    }
}