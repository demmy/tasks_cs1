namespace Engines
{
    public interface IEngine
    {
        int Speed { get; }
        void Start();
        void Stop();
        void Explode();
    }
}
