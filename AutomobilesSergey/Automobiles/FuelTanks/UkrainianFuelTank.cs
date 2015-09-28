namespace FuelTanks
{
    public class UkrainianFuelTank: IFuelTank
    {
        private static double _maxCpacity = 60;
        private double _currentCapacity;

        public UkrainianFuelTank()
        {
            _currentCapacity = _maxCpacity;
        }
        public double Capacity {
            get { return _currentCapacity; }
            set
            {
                _currentCapacity = value;
                if (OnFuelCapacityChanged != null)
                    OnFuelCapacityChanged(Capacity);
            }
        }

        public event FuelLow OnFuelCapacityChanged;
    }
}
