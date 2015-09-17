using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Nikita
{
    class StudentDictionary : KeyedCollection<Tuple<string, string>, Student>
    {
        protected override Tuple<string, string> GetKeyForItem(Student item)
        {
            return new Tuple<string, string>(item.FirstName, item.LastName);
        }
    }

    class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
