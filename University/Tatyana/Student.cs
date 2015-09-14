using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Tatyana
{
    class Student : Person
    {
        public Student(string fn, string mn, string ln, DateTime birth) :
            base(fn, mn, ln, birth)
        {
        }

    }
}
