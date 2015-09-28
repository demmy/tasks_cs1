using GearBoxes;
using Panels;

namespace Automobiles
{
    abstract class Automobile<T> : Automobile
    {
        private readonly T _model;
        protected Automobile(string title, T model) : base(title)
        {
            _model = model;
        }

        public T Model
        {
            get { return _model; }
        }
    }
    abstract class Automobile
    {
        protected IPanel Panel;
        private bool _lightOn;
        private readonly string _title;
        protected Automobile(string title)
        {
            _lightOn = false;
            _title = title;
        }
        public string Title {
            get { return _title; }
        }

        public double Speed
        {
            get { return Panel.Speed; }
        }

        public double FuelCapacity
        {
            get { return Panel.FuelCapacity; }
        }

        public int Dirrection
        {
            get { return Panel.Dirrection; }
        }

        public void Start()
        {
            Panel.StartEngine();
        }

        public void Stop()
        {
            Panel.StopEngine();
        }

        public void TurnLeft(int angle)
        {
            Panel.TurnLeft(angle);
        }

        public void TurnRight(int angle)
        {
            Panel.TurnRight(angle);
        }

        public void Accelerate(double pressure)
        {
            Panel.Accelerate(pressure);
        }

        public void Brake(double pressure)
        {
            Panel.Brake(pressure);
        }

        public void TurnLightOver()
        {
            _lightOn ^= true;
        }

        public event SpeedChange OnSpeedChange
        {
            add { Panel.OnSpeedChange += value; }
            remove { Panel.OnSpeedChange -= value; }
        }
    }
}
