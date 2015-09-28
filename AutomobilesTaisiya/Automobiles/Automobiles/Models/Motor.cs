using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles.Models
{
    class Motor: Interfaces.IMotor
    {
        public int MaxSpeed { get; set; }
        public int CurrentSpeed { get; set; }


        public Motor(int maxSpeed)
        {
            MaxSpeed = maxSpeed;
            CurrentSpeed = 0;
        }
    }
}
