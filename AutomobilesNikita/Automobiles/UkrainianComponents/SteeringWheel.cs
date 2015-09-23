using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComponentsInterfaces;

namespace UkrainianComponents
{
    public class SteeringWheel : ISteeringWheel
    {
        private int _luft = 10;
        public SteeringWheel()
        {
        }

        public int Luft
        {
            get { return _luft; }
            set { _luft = value; }
        }
    }
}