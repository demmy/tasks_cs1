using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComponentsInterfaces;


namespace Automobiles
{
    public class Factory : ICarFactory
    {
        private readonly List<IEngine> _engines = new List<IEngine>();
        private readonly List<ISteeringWheel> _steeringWheels = new List<ISteeringWheel>();
        private readonly List<IGasolineTank> _gasolineTanks = new List<IGasolineTank>();
        private readonly List<IControlPanel> _controlPanels = new List<IControlPanel>();
        private readonly List<ITransmission> _transmission = new List<ITransmission>();
        private readonly List<IPedals> _pedales = new List<IPedals>();

        public IComponentsFactory ComponentsFactory { get; private set; }

        public Factory(CarType carType)
        {
            ComponentsFactory = carType == CarType.Ukrainian ? (IComponentsFactory) new UkrainianComponentsFactory() : new GermanComponentsFactory();
            MakeOneOfEachComponents();
        }

        private void MakeOneOfEachComponents()
        {
            _engines.Add(ComponentsFactory.CreateEngine());
            _steeringWheels.Add(ComponentsFactory.CreateWheel());
            _gasolineTanks.Add(ComponentsFactory.CreateTank());
            _controlPanels.Add(ComponentsFactory.CeratePanel());
            _transmission.Add(ComponentsFactory.CreateTransmission());
            _pedales.Add(ComponentsFactory.CreatePedals());
        }
        public ICar CreateCar(string name)
        {
            MakeOneOfEachComponents();
            return new Car(name, _controlPanels.Last(), _engines.Last(), _gasolineTanks.Last(), _pedales.Last(), _transmission.Last(), _steeringWheels.Last());
        }
    }
}