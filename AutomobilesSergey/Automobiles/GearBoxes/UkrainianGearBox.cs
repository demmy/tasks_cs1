using GearBoxes;

namespace Gearboxes
{
    public enum UkrainianGearBoxState
    {
        Back = -20,
        Neutral = 0,
        First = 20,
        Second = 40,
        Third = 60,
        Fourth = 90,
        Fifth = 120,
        Sixth = 220
    }
    public class UkrainianGearBox:IGearbox
    {
        private double _speed;
        private UkrainianGearBoxState _state;

        public UkrainianGearBox()
        {
            _state = UkrainianGearBoxState.Neutral;
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

        public UkrainianGearBoxState State
        {
            get { return _state; }
        }

        public event SpeedChange OnSpeedChange;
    }
}
