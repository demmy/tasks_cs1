using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Nikita
{
    class Student : Person
    {
        private readonly string _groupId;
        public Student(int age, string firstName, string lastName, string groupId)
            : base(age, firstName, lastName)
        {
            _groupId = groupId;
        }

        public bool CompareGroup(string groupId)
        {
            return String.Equals(_groupId, groupId);
        }
    }
}