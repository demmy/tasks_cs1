using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles
{
    class Car :ICar
    {
        string name;
        double speed;
        double direction;
        double power;
        double angle;

        public string Name
        {
            get { return name; }
        }

        public void PressBreak(double power)
        {
            throw new NotImplementedException();
        }

        public void PressGas(double power)
        {
            throw new NotImplementedException();
        }

        public void TurnSteeringWheelRight(double angle)
        {
            throw new NotImplementedException();
        }

        public void TurnSteeringWheelLeft(double angle)
        {
            throw new NotImplementedException();
        }

        public void OnHeadLight()
        {
            throw new NotImplementedException();
        }

        public void OffHeadLight()
        {
            throw new NotImplementedException();
        }

        public double Speed()
        {
            throw new NotImplementedException();
        }

        public double Direction()
        {
            throw new NotImplementedException();
        }

        public double RemainderFuel()
        {
            throw new NotImplementedException();
        }
    }
}
