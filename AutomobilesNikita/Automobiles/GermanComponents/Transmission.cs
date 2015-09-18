
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComponentsInterfaces;

namespace GermanComponents
{

    public class Transmission : ITransmission
    {
        int _groundResistance = 7;
        public Transmission()
        {
        }

        public int GroundResistance
        {
            get { return _groundResistance; }
            set { _groundResistance = value; }
        }
    }
}