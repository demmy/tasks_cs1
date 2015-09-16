using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Nikita
{
    class Person : IReadOnlyPerson
    {
        public string FullName { get; private set; }
        public int Age { get; private set; }

        public Person(int age, string firstName, string lastName)
        {
            Age = age;
            FullName = firstName + lastName;
        }
    }
}