using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    interface IStudentFactory
    {
        IStudent CreateRandomStudent();

        IMarksCalculator MarksCalculator { get; }

        string ProgrammerName { get; }
    }
}
