using Engines;

namespace Pedals
{
    public class UkrainianPedals:IPedals
    {
        private readonly IEngine _engine;
        private static double _pressureCollision = 5.3;

        public UkrainianPedals()
        {
            _engine = new UkrainianEngine();
        }
        public IEngine Engine
        {
            get { return _engine; }
        }

        public void Brake(double pressure)
        {
            Engine.Gearbox.Speed -= pressure - _pressureCollision;
        }

        public void Accelerate(double pressure)
        {
            Engine.Gearbox.Speed += pressure - _pressureCollision;
        }
    }
}
