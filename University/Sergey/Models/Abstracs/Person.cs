using System;

namespace University.Sergey.Models.Abstracts
{
    internal abstract class Person : IReadOnlyPerson
    {
        private readonly string _firstName;
        private readonly string _familyName;
        private readonly string _patronymic;
        private DateTime _dateOfBirth;

        protected Person(string firstName, string patronymic, string familyName, DateTime dateOfBirth)
        {
            _firstName = firstName;
            _patronymic = patronymic;
            _familyName = familyName;
            _dateOfBirth = dateOfBirth;
        }

        public string FullName
        {
            get { return string.Format("{0} {1} {2}", _firstName, _patronymic, _familyName); }
        }

        public int Age
        {
            get
            {
                var now = DateTime.Today;
                int age = now.Year - _dateOfBirth.Year;
                return (_dateOfBirth > now.AddYears(-age)) ? age - 1 : age;
            }
        }
    }
}