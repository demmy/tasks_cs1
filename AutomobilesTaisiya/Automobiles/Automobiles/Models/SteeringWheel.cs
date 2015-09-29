using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles.Models
{
    class SteeringWheel: Interfaces.ISteeringWheel
    {
        public int AngleDegree { get; set; }

        public SteeringWheel()
        {
            AngleDegree = 0;
        }
    }
}
