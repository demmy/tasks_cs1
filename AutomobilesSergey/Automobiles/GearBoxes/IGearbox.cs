namespace GearBoxes
{
    public delegate void SpeedChange(double speed);
    public interface IGearbox
    {
        double Speed { get; set; }
        event SpeedChange OnSpeedChange;
    }
}
