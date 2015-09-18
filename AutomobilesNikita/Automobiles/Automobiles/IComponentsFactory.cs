using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComponentsInterfaces;

namespace Automobiles
{
    public interface IComponentsFactory
    {
        IEngine CreateEngine();
        ISteeringWheel CreateWheel();
        IGasolineTank CreateTank();
        IPedals CreatePedals();
        IControlPanel CeratePanel();
        ITransmission CreateTransmission();
    }
}