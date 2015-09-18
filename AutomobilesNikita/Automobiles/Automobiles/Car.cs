
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComponentsInterfaces;


namespace Automobiles
{
    public class Car : ICar
    {
        private IEngine _engine;
        private IGasolineTank _gasolineTank;
        private ISteeringWheel _steeringWheel;
        private IControlPanel _controlPanel;
        private ITransmission _transmission;
        private IPedals _pedals;

        public string Name { get; private set; }
        public int Fuel { get; private set; }
        public int Direction { get; private set; }
        public Lights Lights { get; private set; }
        public int Speed { get; private set; }

        public Car(IControlPanel controlPanel, IEngine engine, IGasolineTank gasolineTank, IPedals pedals, ITransmission transmission, ISteeringWheel steeringWheel)
        {
            _controlPanel = controlPanel;
            _engine = engine;
            _gasolineTank = gasolineTank;
            _pedals = pedals;
            _transmission = transmission;
            _steeringWheel = steeringWheel;
        }


        public void PressAccelerator(int pressurePower)
        {
            throw new NotImplementedException();
        }

        public void PressBrakes(int pressurePower)
        {
            throw new NotImplementedException();
        }

        public void RotateSteeringWheelRight(int angle)
        {
            throw new NotImplementedException();
        }

        public void RotateSteeringWheelLeft(int angle)
        {
            throw new NotImplementedException();
        }

        public void TurnOnFarLights()
        {
            throw new NotImplementedException();
        }

        public void TurnOnCloseLights()
        {
            throw new NotImplementedException();
        }

        public void TurnOffLights()
        {
            throw new NotImplementedException();
        }
    }
}