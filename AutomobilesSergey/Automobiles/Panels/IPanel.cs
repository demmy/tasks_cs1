using Engines;
using FuelTanks;
using GearBoxes;
using Pedals;
using SteeringWheel;

namespace Panels
{
    /// <summary>
    /// Realizes the Facade pattern, and in some way mediator
    /// </summary>
 
    public interface IPanel
    {
        //IEngine Engine { get; }
        //IPedals Pedals { get; }
        //IGearbox Gearbox { get; }
        //IFuelTank FuelTank { get; }
        //ISteeringWheel SteeringWheel { get; }

        double Speed { get; }
        double FuelCapacity { get; }
        int Dirrection { get; }

        void StartEngine();
        void StopEngine();

        void TurnLeft(int angle);
        void TurnRight(int angle);
        void Brake(double pressure);
        void Accelerate(double pressure);

        event SpeedChange OnSpeedChange;
    }
}
