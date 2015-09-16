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
        public Teacher(int age, string firstName, string secondName, PositionType position)
            : base(age, firstName, secondName)
        {
            Position = position;
        }
    }
}