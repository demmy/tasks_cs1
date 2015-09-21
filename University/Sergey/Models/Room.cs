using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Sergey.Models
{
    enum Building
    {
        A,
        B,
        C,
        D
    }
    class Room: IRoom
    {
        private readonly Building _building;
        private readonly string _number;
        public string Id {
            get { return string.Format("{0}/{1}", _building, _number); }}

        public Room(Building building, string number)
        {
            _number = number;
            _building = building;
        }
    }
}
