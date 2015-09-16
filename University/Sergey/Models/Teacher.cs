using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Sergey.Models.Abstracts;

namespace University.Sergey.Models
{
    class Teacher:Person
    {
        public Teacher(string firstName, string patronymic, string familyName, DateTime dateOfBirth) : base(firstName, patronymic, familyName, dateOfBirth)
        {
        }
    }
}
