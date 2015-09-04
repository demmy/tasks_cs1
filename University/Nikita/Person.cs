using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Nikita
{
    class Person : IReadOnlyPerson
    {
        public string FullName { get; set; }
        public int Age { get; private set; }

        public Person(int age, string fullName)
        {
            Age = age;
            FullName = fullName;
        }
    }
}
