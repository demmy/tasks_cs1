using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Nikita
{
    enum Building
    {
        A, B, C, D
    }
    class Room: IRoom
    {
        public Building Building { get; private set; }
        public int Number { get; private set; }

        public string Id
        {
            get { return string.Format("{0} {1}", Building, Number); } 
        }

        public Room(Building building, int number)
        {
            Building = building;
            Number = number;
        }
    }
}
