using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Tatyana
{
    class Person: IReadOnlyPerson
    {
        string firstName;
        string middleName;
        string lastName;
        DateTime birthDate;

        public Person()
        {
        }

        public Person(string fn, string mn, string ln, DateTime birth)
        {
            firstName = fn;
            middleName = mn;
            lastName = ln;
            birthDate = birth;
        }

        public string FullName
        {
            get { return string.Format("{0} {1} {2}", firstName, middleName, lastName); }
        }


        public int Age
        {
            get { return (new DateTime((DateTime.Now - birthDate).Ticks)).Year-1; }
        }
    }
}
