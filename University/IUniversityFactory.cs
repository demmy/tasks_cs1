using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    interface IUniversityFactory
    {
        string ProgrammerName { get; }

        IUniversity CreateUniversity(string title);
    }
}
