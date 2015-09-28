using Engines;

namespace Pedals
{
    public interface IPedals
    {
        IEngine Engine { get; }
        void Brake(double pressure);
        void Accelerate(double pressure);
    }
}
