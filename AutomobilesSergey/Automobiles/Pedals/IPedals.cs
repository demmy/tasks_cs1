namespace Pedals
{
    public interface IPedals
    {
        void Brake(int pressure);
        void Accelerate(int pressure);
    }
}
