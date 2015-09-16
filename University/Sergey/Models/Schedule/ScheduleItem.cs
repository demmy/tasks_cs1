using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Sergey.Models.Schedule
{
    partial class Schedule
    {
        internal enum LessonsOrder
        {
            ZeroLesson,
            FirstLesson,
            SecondLesson,
            ThirdLesson,
            FourthLesson,
            FifthLesson,
            SixthLesson,
            SeventhLesson,
            EighthLesson
        }
        private class ScheduleItem
        {
            private LessonsOrder lesson;
            private IEnumerable<IReadOnlyTeacher> teachers;
        }
    }
}
