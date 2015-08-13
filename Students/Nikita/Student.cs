using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Nikita
{
    class Student : IStudent
    {
        private string _firstName;
        private string _secondName;
        private Mark _mark;
        private Dictionary<Subject, Mark> _subjectsMarks;
        private DateTime _birthDate;

        public Group CurrentGroup { get; set; }


        public Student(string firstName, string secondName, Mark mark, Group group, Dictionary<Subject, Mark> subjectsMarks, DateTime birthDate)
        {
            _firstName = firstName;
            _secondName = secondName;
            _mark = mark;
            CurrentGroup = group;
            _subjectsMarks = subjectsMarks;
            _birthDate = birthDate;
        }

        public int Age
        {
            get { return ((new DateTime(1, 1, 1) + (DateTime.Now - _birthDate)).Year - 1); }
        }

        public string FullName
        {
            get { return string.Format("{0} {1}", _firstName, _secondName); }
        }

        public Mark GetMark(Subject subject)
        {
            foreach (var pair in _subjectsMarks)
            {
                if (pair.Key == subject)
                {
                    return pair.Value;
                }
            }
            return Mark.Bad;
        }

        public void SetMark(Subject subject, Mark mark)
        {
            foreach (var pair in _subjectsMarks)
            {
                if (pair.Key == subject)
                {
                    _subjectsMarks[pair.Key] = mark;
                }
            }
        }


        public IReadOnlyDictionary<Subject, Mark> GetAllMarks()
        {
            return _subjectsMarks;
        }
    }
}
