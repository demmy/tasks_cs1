using Engines;
using FuelTanks;
using GearBoxes;
using Pedals;
using SteeringWheel;

namespace Panels
{
    public class UkrainianPanel:IPanel
    {
        private readonly IPedals _pedals;
        private readonly ISteeringWheel _wheel;
        // Inside elements
        private readonly IGearbox _gearbox;
        private readonly IEngine _engine;
        private readonly IFuelTank _fuelTank;

        public UkrainianPanel()
        {
            _pedals = new UkrainianPedals();
            _wheel = new UkrainianSteeringWheel();
            _engine = _pedals.Engine;
            _gearbox = _engine.Gearbox;
            _fuelTank = _engine.Tank;
        }
        public double Speed
        {
            get { return _gearbox.Speed; }
        }

        public double FuelCapacity
        {
            get { return _fuelTank.Capacity; }
        }

        public int Dirrection
        {
            get { return _wheel.Angle; }
        }

        public void StartEngine()
        {
            _engine.Start();
        }

        public void StopEngine()
        {
            _engine.Stop();
        }

        public void TurnLeft(int angle)
        {
            _wheel.Turn(angle);
        }

        public void TurnRight(int angle)
        {
            _wheel.Turn(-1*angle);
        }

        public void Brake(double pressure)
        {
            _pedals.Brake(pressure);
        }

        public void Accelerate(double pressure)
        {
            _pedals.Accelerate(pressure);
        }

        public event SpeedChange OnSpeedChange
        {
            add { _gearbox.OnSpeedChange += value; }
            remove { _gearbox.OnSpeedChange -= value; }
        }
    }
}
