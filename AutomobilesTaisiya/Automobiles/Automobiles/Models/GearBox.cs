using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles.Models
{
    class GearBox: Interfaces.IGearBox
    {
        public int GearNumber { get; set; }

        public GearBox(int gearNumber)
        {
            GearNumber = gearNumber;
        }

    }
}
