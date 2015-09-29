using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles.Models
{
    class Pedal: Interfaces.IPedal
    {
        public int TreadleEffort { get; set; }

        public Pedal(int treadleEffort)
        {
            TreadleEffort = treadleEffort;
        }
    }
}
