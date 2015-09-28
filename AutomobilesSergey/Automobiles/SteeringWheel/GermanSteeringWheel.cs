namespace SteeringWheel
{
    public class GermanSteeringWheel:ISteeringWheel
    {
        private int _angle;
        private static int _luft = 5;
        public int Angle
        {
            get { return _angle; }
        }

        public void Turn(int angle)
        {
            _angle += (angle - _luft) >=0 ? angle -_luft : 0;
            _angle %= 360;
        }
    }
}
