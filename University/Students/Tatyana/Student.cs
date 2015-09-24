using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Tatyana
{
    class Student : IStudent
    {



        string firstName;
        string lastName;
        DateTime dateOfBirth;
        Dictionary<Subject, Mark> marks;
        public Group CurrentGroup { get; set; }


        public int Age
        {
            get { return new DateTime((DateTime.Now - dateOfBirth).Ticks).Year; }
        }

        public string FullName
        {
            get { return firstName + " " + lastName; }
        }

        public Student(string firstName1, string lastName1, DateTime dateOfBirth1,
                               Group group)
        {
            firstName = firstName1;
            lastName = lastName1;
            dateOfBirth = dateOfBirth1;
            CurrentGroup = group;
            marks = new Dictionary<Subject, Mark>();
        }
        public Student(string firstName1, string lastName1, DateTime dateOfBirth1,
                                   Group group, Dictionary<Subject, Mark> marks1)
        {
            firstName = firstName1;
            lastName = lastName1;
            dateOfBirth = dateOfBirth1;
            CurrentGroup = group;
            marks = marks1;
        }


        public Mark GetMark(Subject subject)
        {
            Mark result = Mark.NoMark;
            Mark result1;
            if (marks.TryGetValue(subject, out result1))
            {
                result = result1;
            }
            return result;
        }

        public void SetMark(Subject subject, Mark mark)
        {
            marks[subject] = mark;
        }

        public IReadOnlyDictionary<Subject, Mark> GetAllMarks()
        {
            return marks;
        }
        
    }
}
