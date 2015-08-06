using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    interface IMarksCalculator
    {
        IReadOnlyList<KeyValuePair<IStudent, double>> AverageMarkPerStudent(IReadOnlyList<IStudent> students);

        IReadOnlyList<KeyValuePair<Mark, double>> AverageMarkPerSubject(IReadOnlyList<IStudent> students);

        IReadOnlyList<KeyValuePair<Group, double>> AverageMarkPerGroup(IReadOnlyList<IStudent> students);

        IReadOnlyList<KeyValuePair<Tuple<Group, Subject>, double>> 
            AverageMarkPerGroupPerSubject(IReadOnlyList<IStudent> students);
    }
}
