using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Tatyana
{
    class UniversityFactory : IUniversityFactory
    {
        public IUniversity CreateUniversity(string title)
        {
            throw new NotImplementedException();
        }

        public string ProgrammerName
        {
            get { throw new NotImplementedException(); }
        }
    }
}
