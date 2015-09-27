using Engines;
using FuelTanks;
using GearBoxes;
using Pedals;
using SteeringWheel;

namespace Panels
{
    /// <summary>
    /// Realizes the Facade pattern, and some way mediator
    /// </summary>
 
    interface IPanel
    {
        IEngine GetEngine();
        IPedals GetPedals();
        IGearbox GetGearbox();
        IFuelTank GetFuelTank();
        ISteeringWheel GetSteeringWheel();

        int Speed { get; }
        int FuelCapacity { get; }
        int Dirrection { get; }
    }
}
