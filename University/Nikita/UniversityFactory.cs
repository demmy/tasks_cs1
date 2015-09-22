using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Nikita
{
    class UniversityFactory : IUniversityFactory
    {
        public IUniversity CreateUniversity(string title)
        {
            return new University(title)
            {

            };
        }

        public string ProgrammerName
        {
            get { return "Nikita"; }
        }
    }
}
