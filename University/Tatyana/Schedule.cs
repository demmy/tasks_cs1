using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Tatyana
{
   

    class Schedule : ISchedule
    {
        
        Dictionary<DateTime, List<ScheduleItem>> items;
        TimeSpan[] timeOfStart;

        public Schedule()
        {
        }
            
        public Schedule(Dictionary<DateTime, List<ScheduleItem>>  items1)
        {
            items = items1;
            timeOfStart = new TimeSpan[9] { new TimeSpan(6, 30, 0), new TimeSpan(8,0,0),
               new TimeSpan(9,30,0), new TimeSpan(11,10,0), new TimeSpan(12,30,0),
               new TimeSpan(14,10,0), new TimeSpan(15,40,0), new TimeSpan(16,10,0) ,
                new TimeSpan(17,30,0) };
        }

        private TimeSpan TimeOfStart(LessonsOrder lesson)
        {
            return timeOfStart[(int)lesson];
        }

        public IReadOnlyDictionary<string, Tuple<DateTime, string, IReadOnlyList<string>>> GetByDay(DateTime day)
        {
            Dictionary<string, Tuple<DateTime, string, IReadOnlyList<string>>> roomsTimeTable =
                new Dictionary<string, Tuple<DateTime, string, IReadOnlyList<string>>>();
            

            if (items.ContainsKey(day))
            {
                List<ScheduleItem> dayLessonTimeTable = items[day];
                foreach (ScheduleItem item in dayLessonTimeTable)
                {
                    string room = item.room.Id;
                        if (!roomsTimeTable.ContainsKey(room))
                        { 
                            TimeSpan t=TimeOfStart(item.lesson);
                            DateTime date=new DateTime(day.Year,day.Month,day.Day,t.Hours,t.Minutes,t.Seconds);
                            List<string> group = new List<string>();
                            string teacher=item.teacher.FullName;
                            foreach(Group g in item.groups )
                            {
                                group.Add(g.ID);
                            }
                            
                            Tuple<DateTime, string, IReadOnlyList<string>> timeTeacherGroups=
                                new Tuple<DateTime,string,IReadOnlyList<string>>(date,teacher,group);
                            roomsTimeTable[room] = timeTeacherGroups;
                        }
                }
                

            }

            return roomsTimeTable;
                                                            
        }

        public IReadOnlyDictionary<DateTime, IReadOnlyDictionary<string, Tuple<DateTime, string, IReadOnlyList<string>>>> GetAll()
        {
            Dictionary<DateTime, IReadOnlyDictionary<string, Tuple<DateTime, string, IReadOnlyList<string>>>> timeOfStartDay =
                new Dictionary<DateTime, IReadOnlyDictionary<string, Tuple<DateTime, string, IReadOnlyList<string>>>>();
            

            return timeOfStartDay;
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
