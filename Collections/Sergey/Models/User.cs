using System;

namespace Collections.Sergey.Models
{
    class User
    {
        private readonly string _firstName;
        private readonly string _familyName;
        private readonly DateTime _dateOfBirth;

        public User(string firstName, string familyName, DateTime dateOfBirth)
        {
            _firstName = firstName;
            _familyName = familyName;
            _dateOfBirth = dateOfBirth;
        }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, FamilyName);
            }
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

        public string FirstName
        {
            get { return _firstName; }
        }

        public string FamilyName
        {
            get { return _familyName; }
        }

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
        }
    }
}
