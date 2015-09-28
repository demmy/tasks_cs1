namespace FuelTanks
{
    public class GermanFuelTank: IFuelTank
    {
        private static double _maxCpacity = 72.1;
        private double _currentCapacity;

        public GermanFuelTank()
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
