using System;
using University.Sergey.Models.Abstracts;

namespace University.Sergey.Models
{
    class Teacher: Person, IReadOnlyTeacher
    {
        private PositionType _position;
        public Teacher(string firstName, string patronymic, string familyName, DateTime dateOfBirth, PositionType position) : base(firstName, patronymic, familyName, dateOfBirth)
        {
            _position = position;
        }

        public PositionType Position
        {
            get { return _position; }
        }
    }
}
