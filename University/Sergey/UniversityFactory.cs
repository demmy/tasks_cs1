using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Sergey
{
    class UniversityFactory : IUniversityFactory
    {
        public IUniversity CreateUniversity(string title)
        {
            return new Models.University(title);
        }

        public string ProgrammerName
        {
            get { return "Sergey Matvienko"; }
        }
    }
}
