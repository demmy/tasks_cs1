using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Collections.Tatyana
{
    class Student
    {
        public string firstName;
        public string lastName;
        public string[] subject = new string[0];
        public int[] marks = new int[0];


    }

     class StudentDictionary : KeyedCollection<Tuple<string, string>, Student>
    {
        protected override Tuple<string, string> GetKeyForItem(Student item)
        {
            return new Tuple<string, string>(item.firstName, item.lastName);

        }
    }
}
