
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
        public double Fuel { get; private set; }
        public int Direction { get; private set; }
        public Lights Lights { get; private set; }
        public int Speed { get; private set; }

        public Car(string name,IControlPanel controlPanel, IEngine engine, IGasolineTank gasolineTank, IPedals pedals, ITransmission transmission, ISteeringWheel steeringWheel)
        {
            Name = name;
            Direction = 90;
            _controlPanel = controlPanel;
            _engine = engine;
            _gasolineTank = gasolineTank;
            _pedals = pedals;
            _transmission = transmission;
            _steeringWheel = steeringWheel;
        }

        public void RefreshCarState()
        {
            Fuel -= 0.146*Speed;
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