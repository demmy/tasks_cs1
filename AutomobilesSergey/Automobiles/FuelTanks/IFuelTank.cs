namespace FuelTanks
{
    public delegate void FuelLow(double capacity);
    public interface IFuelTank
    {
        double Capacity { get; set; }
        event FuelLow OnFuelCapacityChanged;
    }
}
