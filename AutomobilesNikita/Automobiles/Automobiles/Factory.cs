using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComponentsInterfaces;


namespace Automobiles
{
    public class Factory : ICarFactory
    {
        private IEnumerable<IEngine> _engines = new List<IEngine>();
        private IEnumerable<ISteeringWheel> _steeringWheels = new List<ISteeringWheel>();
        private IEnumerable<IGasolineTank> _gasolineTanks = new List<IGasolineTank>();
        private IEnumerable<IControlPanel> _controlPanels = new List<IControlPanel>();
        private IEnumerable<ITransmission> _transmission = new List<ITransmission>();
        private IEnumerable<IPedals> _pedales = new List<IPedals>();

        public IComponentsFactory ComponentsFactory { get; private set; }

        public Factory(IComponentsFactory componentsFactory)
        {
            ComponentsFactory = componentsFactory;
        }

        public ICar CreateCar()
        {
            return null;
        }
    }
}