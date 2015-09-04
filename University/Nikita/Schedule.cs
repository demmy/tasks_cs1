using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Nikita
{
    class Schedule : ISchedule
    {
        private Dictionary<DateTime, List<ScheduleItem>> _items;

        public Schedule(Dictionary<DateTime, List<ScheduleItem>> items)
        {
           _items = items;
        }
        /// <returns>list of lessons data per room: name of room, time of start, 
        /// name of teacher, list of group names.</returns>
        public IReadOnlyDictionary<string, Tuple<DateTime, string, IReadOnlyList<string>>> GetByDay(DateTime day)
        {
           
        }

        public IReadOnlyDictionary<DateTime, IReadOnlyDictionary<string, Tuple<DateTime, string, IReadOnlyList<string>>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IReadOnlyDictionary<DateTime, Tuple<DateTime, string, IReadOnlyList<string>>> GetByRoom(string roomName)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyDictionary<DateTime, Tuple<DateTime, string, bool>> GetByGroup(string groupName)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyDictionary<DateTime, Tuple<DateTime, string, IReadOnlyList<string>>> GetByTeacher(string teacherName)
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
