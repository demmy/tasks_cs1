using System;
using University.Sergey.Models.Abstracts;

namespace University.Sergey.Models
{
    class Student: Person
    {
        public Student(string firstName, string patronymic, string familyName, DateTime dateOfBirth) : base(firstName, patronymic, familyName, dateOfBirth)
        {
        }
    }
}
