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
        private string firstName;
        private string lastName;
        private Dictionary<string, int> subjects = new Dictionary<string, int>();
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
        
        public Student(string firstName1, string lastName1)
    {
            firstName=firstName1;
            lastName = lastName1;
        
    }
        public IEnumerable<string> GetSubject()
        {
            return subjects.Keys;
            }
        public IEnumerable<int> GetMarks()
        {
            return subjects.Values;
        }
        public int this[string subject]
        {
            get
            {
                return subjects[subject];
            }
        }
        public void AddSubjectMarks(string s, int i)
        {
            subjects[s] = i;
        }

    }

     class StudentDictionary : KeyedCollection<Tuple<string, string>, Student>
    {
        protected override Tuple<string, string> GetKeyForItem(Student item)
        {
            return new Tuple<string, string>(item.FirstName, item.LastName );
        }
    }
}
