using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Tatyana
{
    enum Building  {A, B, C, D, AfterLastPosition}
    class Room  : IRoom
    {
        Building building;
        int number;

        public string Id
        {
            get { return string.Format("{0}_{1}", building, number); }
        }

        public Room(Building b, int number1)
        {
            building = b;
            number = number1;
        }
    }
}
