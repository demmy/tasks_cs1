
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComponentsInterfaces;


namespace Automobiles
{

    public class Car : ICar
    {
        public class CarEventArgs : EventArgs
        {
            private string _data;

            public CarEventArgs(string data)
            {
                _data = data;
            }

            public string Data
            {
                get { return _data; }
            }
        }

        private event EventHandler<CarEventArgs> Stopped = delegate(object sender, CarEventArgs args) {  }; 
        private IEngine _engine;
        private IGasolineTank _gasolineTank;
        private ISteeringWheel _steeringWheel;
        private IControlPanel _controlPanel;
        private ITransmission _transmission;
        private IPedals _pedals;

        public string Name { get; private set; }

        public double Fuel
        {
            get { return _gasolineTank.FuelAmount; }
            set { _gasolineTank.FuelAmount = value; }
        }

        public int Direction { get; private set; }
        public Lights Lights { get; private set; }
        public int Speed { get; private set; }

        public Car(string name,IControlPanel controlPanel, IEngine engine, IGasolineTank gasolineTank, IPedals pedals, ITransmission transmission, ISteeringWheel steeringWheel)
        {
            Name = name;
            Direction = 90;
            Lights = Lights.Off;
            _controlPanel = controlPanel;
            _engine = engine;
            _gasolineTank = gasolineTank;
            _pedals = pedals;
            _transmission = transmission;
            _steeringWheel = steeringWheel;
            Stopped += OnCarStopped();
        }

        private EventHandler<CarEventArgs> OnCarStopped()
        {
            Speed = 0;
        }

        public void RefreshCarState()
        {
            Fuel -= 0.146*Speed;
            if (Fuel <= 0) Stopped(this, new CarEventArgs("Fuel ended"));
        }

        public void PressAccelerator(int pressurePower)
        {
            Speed = Speed + pressurePower;
        }

        public void PressBrakes(int pressurePower)
        {
            Speed = Speed - pressurePower;
        }

        public void RotateSteeringWheelRight(int angle)
        {
            Direction += angle > _steeringWheel.Luft ? angle - _steeringWheel.Luft : 0;
        }

        public void RotateSteeringWheelLeft(int angle)
        {
            Direction -= angle > _steeringWheel.Luft ? angle - _steeringWheel.Luft : 0;

        }

        public void TurnOnFarLights()
        {
            Lights=Lights.Far;
        }

        public void TurnOnCloseLights()
        {
            Lights = Lights.Close;
        }

        public void TurnOffLights()
        {
            Lights = Lights.Off;
        }
    }


}