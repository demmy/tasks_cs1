namespace SteeringWheel
{
    public interface ISteeringWheel
    {
        int Angle { get; }
        void Turn(int angle);
    }
}
