using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Tatyana
{
    class Teacher: Person, IReadOnlyTeacher
    {
        public PositionType Position { get; set;  }
        public bool IsFired { get; set; }

        public Teacher(string fn, string mn, string ln, DateTime birth) :
            base(fn, mn, ln, birth)
        {
        }

        public Teacher(string fn, string mn, string ln, DateTime birth, PositionType position) :
            base(fn, mn, ln, birth)
        {
            Position = position;
        }
}
}
