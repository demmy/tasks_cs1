using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections.Sergey.Models
{
    class Student: User
    {
        public Student(string firstName, string familyName, DateTime dateOfBirth) : base(firstName, familyName, dateOfBirth)
        {
        }

        public string FirstName
        {
            get
            {
                return FirstName;
            }
        }

        public string FamilyName 
        {
            get
            {
                return FamilyName;
            }
        }
    }
}
