using FuelTanks;
using GearBoxes;

namespace Engines
{
    public interface IEngine
    {
        IFuelTank Tank { get; }
        IGearbox Gearbox { get; }
        void Start();
        void Stop();
    }
}
