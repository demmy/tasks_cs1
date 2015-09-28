using GearBoxes;

namespace Gearboxes
{
    public enum GermanGearBoxState
    {
        Back = -15,
        Neutral = 0,
        First = 25,
        Second = 45,
        Third = 65,
        Fourth = 90,
        Fifth = 130,
        Sixth = 230
    }
    public class GermanGearBox:IGearbox
    {
        private double _speed;
        private GermanGearBoxState _state;

        public GermanGearBox()
        {
            _state = GermanGearBoxState.Neutral;
            OnSpeedChange += speed => { };//TODO implement state changing on speed
        }

        public double Speed
        {
            get { return _speed; }
            set
            {
                _speed = value;
                if (OnSpeedChange != null)
                    OnSpeedChange(_speed);
            }
        }

        public GermanGearBoxState State
        {
            get { return _state; }
        }

        public event SpeedChange OnSpeedChange;
    }
}
