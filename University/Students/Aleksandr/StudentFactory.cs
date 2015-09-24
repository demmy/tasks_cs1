using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Aleksandr
{
    class StudentFactory : IStudentFactory
    {
        public IStudent CreateRandomStudent()
        {
            throw new NotImplementedException();
        }

        public IMarksCalculator MarksCalculator
        {
            get { throw new NotImplementedException(); }
        }


        public string ProgrammerName
        {
            get { throw new NotImplementedException(); }
        }
    }
}
