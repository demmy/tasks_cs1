
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using ComponentsInterfaces;
using Timer = System.Windows.Forms.Timer;


namespace Automobiles
{

    public class Car : ICar
    {
        
        public event EventHandler<CarEventArgs> FuelEnded = delegate(object sender, CarEventArgs args) {  };
        public event EventHandler<CarEventArgs> CarStopped = delegate(object sender, CarEventArgs args) { }; 

        private IEngine _engine;
        private IGasolineTank _gasolineTank;
        private ISteeringWheel _steeringWheel;
        private IControlPanel _controlPanel;
        private ITransmission _transmission;
        private IPedals _pedals;

        private Timer _timer;
        private int _speedSubstract;
        private int _speed;

        public string Name { get; set; }
        public int Direction { get; set; }
        public Lights Lights { get; set; }

        public int Speed
        {
            get { return _speed; }
            set
            {
                if(value==0) CarStopped(this, new CarEventArgs("Car stopped")); 
                _speed = value;
            }
        }

        public double Fuel
        {
            get { return _gasolineTank.FuelAmount; }
            set { _gasolineTank.FuelAmount = value; }
        }

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
            FuelEnded += OnFuelEnded;
        }

        private void OnFuelEnded(object sender, CarEventArgs e)
        {
            _timer = new Timer { Interval = 1000 };
            _timer.Start();
            _timer.Tick += OnTimerElapsed;
            _speedSubstract = Convert.ToInt32(Speed / 20);
        }


        private void OnTimerElapsed(object sender, EventArgs eventArgs)
        {
            Speed -= _speedSubstract;
            if (Speed <= 0)
            {
                StopTimer();
                CarStopped(this, new CarEventArgs("Car stopped"));
            }
        }

        private void StopTimer()
        {
            _timer.Stop();
        }

        public void RefreshCarState(object sender, EventArgs eventArgs)
        {
            Fuel -= 0.00146*Speed;
            if (Fuel <= 0)
            {
                Fuel = 0;
                FuelEnded(this, new CarEventArgs("Fuel ended"));
            }
        }
        
        public void PressAccelerator(int pressurePower)
        {
            Speed = (int) (Speed + pressurePower / (_transmission.GroundResistance*0.25));
        }

        public void PressBrakes(int pressurePower)
        {
            Speed = (int) (Speed - pressurePower/(_transmission.GroundResistance*0.25));
        }

        public void RotateSteeringWheelRight(int angle)
        {
            if (angle > 50)
            {
                Speed /= 2;
            } 
            Direction += angle > _steeringWheel.Luft ? angle - _steeringWheel.Luft : 0;
        }

        public void RotateSteeringWheelLeft(int angle)
        {
            if (angle > 50)
            {
                Speed /= 2;
            }
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

        public override string ToString()
        {
            return string.Format("{0}", Name);
        }
    }


}