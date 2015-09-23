using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Taisiya
{
    class StudentDictionary : KeyedCollection<Tuple<string, string>, Student> 
    {
        protected override Tuple<string, string> GetKeyForItem(Student s)
        {
            return new Tuple<string, string>(s.FirstName, s.LastName);
        }
    }

    class Student
    {
        private string firstName;
        private string lastName;

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
        }
    }
}
