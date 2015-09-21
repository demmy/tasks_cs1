using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Sergey.Models.Schedule
{
    partial class Schedule: ISchedule
    {
        private IDictionary<DateTime, List<ScheduleItem>> _items;

        public IReadOnlyDictionary<string, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>> GetByDay(DateTime day)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyDictionary<DateTime, IReadOnlyDictionary<string, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IReadOnlyDictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>> GetByRoom(string roomName)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyDictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, bool>>> GetByGroup(string groupName)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyDictionary<DateTime, IReadOnlyList<Tuple<DateTime, string, IReadOnlyList<string>>>> GetByTeacher(string teacherName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DateTime> AllExistingDates
        {
            get { throw new NotImplementedException(); }
        }

        public IReadOnlyDictionary<Tuple<DateTime, LessonsOrder>, IReadOnlyList<Tuple<IRoom, IReadOnlyList<IReadOnlyTeacher>, IReadOnlyList<IReadOnlyGroup>>>> GetWeekData(DateTime dateAtThisWeek)
        {
            throw new NotImplementedException();
        }
    }
}
