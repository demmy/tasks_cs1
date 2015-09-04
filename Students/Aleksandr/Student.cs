using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Aleksandr
{
    class Student : IStudent
    {
        public int Age
        {
            get { throw new NotImplementedException(); }
        }

        public string FullName
        {
            get { throw new NotImplementedException(); }
        }

        public Mark GetMark(Subject subject)
        {
            throw new NotImplementedException();
        }

        public void SetMark(Subject subject, Mark mark)
        {
            throw new NotImplementedException();
        }

        public Group CurrentGroup
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public IReadOnlyDictionary<Subject, Mark> GetAllMarks()
        {
            throw new NotImplementedException();
        }
    }
}
