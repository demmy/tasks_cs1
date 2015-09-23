using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Automobiles
{
    public interface ICarFactory
    {
        ICar CreateCar(string name);
    }
}