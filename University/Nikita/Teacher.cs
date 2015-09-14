using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Nikita
{
    class Teacher : Person, IReadOnlyTeacher
    {
        public PositionType Position { get; private set; }
        public Teacher(int age, string fullName, PositionType position)
            : base(age, fullName)
        {
            Position = position;
        }
    }
}