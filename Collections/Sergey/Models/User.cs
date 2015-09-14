using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                return string.Format("{0} {1}", _firstName, _familyName);
            }
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
