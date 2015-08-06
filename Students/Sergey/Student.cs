using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Sergey
{
    class Student : IStudent
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public Group CurrentGroup { get; set; }

        private Dictionary<Subject, Mark> _subjectMarks;

        public Student(DateTime dateOfBirth, string lastName, string firstName)
        {
            DateOfBirth = dateOfBirth;
            LastName = lastName;
            FirstName = firstName;
            _subjectMarks  = new Dictionary<Subject, Mark>();
        }
        
        public int Age
        {
            get
            {
                var now = DateTime.Today;
                int age = now.Year - DateOfBirth.Year;
                return (DateOfBirth > now.AddYears(-age)) ? age - 1 : age;
            }
        }

        public string FullName
        {
            get
            {
                return String.Format("{0} {1}", FirstName, LastName);
            }
        }

        public Mark GetMark(Subject subject)
        {
            Mark currentMark;
            _subjectMarks.TryGetValue(subject, out currentMark);
            return currentMark;
        }

        public void SetMark(Subject subject, Mark mark)
        {
            _subjectMarks.Add(subject, mark);
        }
        
        public IReadOnlyDictionary<Subject, Mark> GetAllMarks()
        {
            return _subjectMarks;
        }
    }
}
