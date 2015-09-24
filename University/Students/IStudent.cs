using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    enum Subject { Math, Physics, Programming, History, English };
    enum Mark { Excellent = 5, Good = 4, Satisfactory = 3, Poor = 2, Bad = 1, NoMark = 0 };
    enum Group { CS1, CS2 };

    interface IStudent
    {
        int Age { get; }

        string FullName { get; }

        Mark GetMark(Subject subject);
        void SetMark(Subject subject, Mark mark);
        IReadOnlyDictionary<Subject, Mark> GetAllMarks();
        Group CurrentGroup { get; set; }
    }
}
