using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles.Interfaces
{
    interface IMotor
    {
        int MaxSpeed{ get; set; }
        int CurrentSpeed { get; set; }
    }
}
