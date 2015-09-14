using System;

namespace Collections.Sergey.Models
{
    class User
    {
        protected readonly string FirstName;
        protected readonly string FamilyName;
        protected readonly DateTime DateOfBirth;

        public User(string firstName, string familyName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            FamilyName = familyName;
            DateOfBirth = dateOfBirth;
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
    }
}
