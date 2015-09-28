using Engines;

namespace Pedals
{
    public class GermanPedals:IPedals
    {
        private readonly IEngine _engine;
        private static double _pressureCollision = 3.2;

        public GermanPedals()
        {
            _engine = new GermanEngine();
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
