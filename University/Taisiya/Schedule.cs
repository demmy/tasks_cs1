using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Taisiya
{
    class Schedule: ISchedule
    {
        private Dictionary<DateTime, List<ScheduleItem>> items;

        private Dictionary<LessonsOrder, DateTime> lessonsTime = new Dictionary<LessonsOrder, DateTime>
        {
            { LessonsOrder.ZeroLesson, new DateTime(2015, 9, 1, 6, 30, 0) },
            { LessonsOrder.FirstLesson, new DateTime(2015, 9, 1, 8, 00, 0) },
            { LessonsOrder.SecondLesson, new DateTime(2015, 9, 1, 9, 35, 0) },
            { LessonsOrder.ThirdLesson, new DateTime(2015, 9, 1, 11, 20, 0) },
            { LessonsOrder.FourthLesson, new DateTime(2015, 9, 1, 12, 55, 0) },
            { LessonsOrder.FirstLesson, new DateTime(2015, 9, 1, 14, 30, 0) },
            { LessonsOrder.SixthLesson, new DateTime(2015, 9, 1, 16, 00, 0) },
            { LessonsOrder.SeventhLesson, new DateTime(2015, 9, 1, 17, 30, 0) },
            { LessonsOrder.EighthLesson, new DateTime(2015, 9, 1, 19, 00, 0) }
        };

        public Schedule(DateTime date, ScheduleItem item)
        {
            if (!this.items.ContainsKey(date))
                this.items[date] = new List<ScheduleItem>();

            this.items[date].Add(item);
        }

        public IReadOnlyDictionary<string, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>> GetByDay(DateTime day)
        {
            Dictionary<string, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>> daySchedule = new Dictionary<string, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>();

            var t = from item in items
                    where item.Key == day
                    from schedItem in item.Value
                    from si in schedItem.Teachers
                    select si.FullName;

            var g = from item in items
                    where item.Key == day
                    from schedItem in item.Value
                    from si in schedItem.Groups
                    select si.ID;

            var r = from item in items
                    where item.Key == day
                    from schedItem in item.Value
                    select schedItem.Room.Id;
            

            IReadOnlyList<string> teachersNames = (IReadOnlyList<string>)t;
            IReadOnlyList<string> groupsNames = (IReadOnlyList<string>)g;
            IReadOnlyList<string> roomsList = (IReadOnlyList<string>)r;


            foreach (var time in lessonsTime)
                foreach (var rl in roomsList)
                {
                    Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>> tupleTemp = Tuple.Create(time.Value, teachersNames, groupsNames);
                    List<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>> tempList = new List<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>();

                    tempList.Add(tupleTemp);

                    Dictionary<string, List<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>> dict
                        = new Dictionary<string, List<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>();

                    daySchedule.Add(rl, tempList);
                }
            
            return daySchedule;
        }

        public IReadOnlyDictionary<DateTime, IReadOnlyDictionary<string, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>> GetAll()
        {
            Dictionary<DateTime, Dictionary<string, List<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>> allSchedule = new Dictionary<DateTime, Dictionary<string, List<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>>();

            var t = from item in items
                    from schedItem in item.Value
                    from si in schedItem.Teachers
                    select si.FullName;

            var g = from item in items
                    from schedItem in item.Value
                    from si in schedItem.Groups
                    select si.ID;

            var r = from item in items
                    from schedItem in item.Value
                    select schedItem.Room.Id;
                     
            IReadOnlyList<string> teachersNames = (IReadOnlyList<string>)t;
            IReadOnlyList<string> groupsNames = (IReadOnlyList<string>)g;
            IReadOnlyList<string> roomsList = (IReadOnlyList<string>)r;

            foreach (var item in items)
                foreach (var time in lessonsTime)
                    foreach (var rl in roomsList)
                            {
                                Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>> tupleTemp = Tuple.Create(time.Value, teachersNames, groupsNames);
                                List<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>> tempList = new List<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>();

                                tempList.Add(tupleTemp);

                                Dictionary<string, List<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>> dict
                                    = new Dictionary<string, List<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>();

                                dict.Add(rl, tempList);
                                allSchedule.Add(item.Key, dict);    
                            }
            
            IReadOnlyDictionary<DateTime, IReadOnlyDictionary<string, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>> getAll = 
                (IReadOnlyDictionary<DateTime, IReadOnlyDictionary<string, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>>)allSchedule;          
            
            return getAll;        
        }

        public IReadOnlyDictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>> GetByRoom(string roomName)
        {
            Dictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>> roomSchedule = new Dictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>();

            var t = from item in items
                    from schedItem in item.Value
                    where schedItem.Room.Id == roomName
                    from si in schedItem.Teachers
                    select si.FullName;

            var g = from item in items
                    from schedItem in item.Value
                    where schedItem.Room.Id == roomName
                    from si in schedItem.Groups
                    select si.ID;              

            IReadOnlyList<string> teachersNames = (IReadOnlyList<string>)t;
            IReadOnlyList<string> groupsNames = (IReadOnlyList<string>)g;

            foreach(var item in items)
                foreach (var time in lessonsTime)
                {
                    Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>> tupleTemp = Tuple.Create(time.Value, teachersNames, groupsNames);
                    List<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>> tempList = new List<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>();

                    tempList.Add(tupleTemp);

                    roomSchedule.Add(item.Key, tempList);
                }
           
            return roomSchedule;
        }

        public IReadOnlyDictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, bool>>> GetByGroup(string groupName)
        {
            Dictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, bool>>> groupSchedule = new Dictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, bool>>>();

            var t = from item in items
                    from schedItem in item.Value
                    from sg in schedItem.Groups
                    where sg.ID == groupName
                    from si in schedItem.Teachers
                    select si.FullName;

            var r = from item in items
                    from scheduleItem in item.Value
                    from sg in scheduleItem.Groups
                    where sg.ID == groupName
                    from schedItem in item.Value
                    select schedItem.Room.Id;

            var g = from item in items
                    from scheduleItem in item.Value
                    from sg in scheduleItem.Groups
                    where sg.ID == groupName
                    select sg;

            IReadOnlyList<string> teachersNames = (IReadOnlyList<string>)t;
            IReadOnlyList<string> roomsList = (IReadOnlyList<string>)r;
            IReadOnlyList<string> groupsNames = (IReadOnlyList<string>)g;

            foreach(var item in items)
                foreach (var time in lessonsTime)
                    foreach (var rl in roomsList)
                        foreach (var tn in teachersNames)
                        {
                            Tuple<DateTime, IReadOnlyList<string>, bool> tupleTemp = Tuple.Create(time.Value, teachersNames, groupsNames.Count > 0);
                            List<Tuple<DateTime, IReadOnlyList<string>, bool>> tempList = new List<Tuple<DateTime, IReadOnlyList<string>, bool>>();

                            tempList.Add(tupleTemp);
                            groupSchedule.Add(item.Key, tempList);
                        }
           
            IReadOnlyDictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, bool>>>  getGroup = 
                (IReadOnlyDictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, bool>>> )groupSchedule;

            return getGroup;        
        }

        public IReadOnlyDictionary<DateTime, IReadOnlyList<Tuple<DateTime, string, IReadOnlyList<string>>>> GetByTeacher(string teacherName)
        {
            Dictionary<DateTime, IReadOnlyList<Tuple<DateTime, string, IReadOnlyList<string>>>> teacherSchedule = new Dictionary<DateTime, IReadOnlyList<Tuple<DateTime, string, IReadOnlyList<string>>>>();

            var g = from item in items
                    from schedItem in item.Value
                    from st in schedItem.Teachers
                    where st.FullName == teacherName
                    from si in schedItem.Groups
                    select si.ID;

            var r = from item in items
                    from scheduleItem in item.Value
                    from st in scheduleItem.Teachers
                    where st.FullName == teacherName
                    from schedItem in item.Value
                    select schedItem.Room.Id;           

            IReadOnlyList<string> roomsList = (IReadOnlyList<string>)r;
            IReadOnlyList<string> groupsNames = (IReadOnlyList<string>)g;


            foreach(var item in items)
                foreach (var time in lessonsTime)
                {
                    Tuple<DateTime, string, IReadOnlyList<string>> tupleTemp = Tuple.Create(time.Value, teacherName, groupsNames);
                    List<Tuple<DateTime, string, IReadOnlyList<string>>> tempList = new List<Tuple<DateTime, string, IReadOnlyList<string>>>();

                    tempList.Add(tupleTemp);

                    teacherSchedule.Add(item.Key, tempList);
                }
           
            return teacherSchedule; 
        }

        public IEnumerable<DateTime> AllExistingDates
        {
            get { return items.Keys; }
        }

        public IReadOnlyDictionary<Tuple<DateTime, LessonsOrder>, IReadOnlyList<Tuple<IRoom, IReadOnlyList<IReadOnlyTeacher>, IReadOnlyList<IReadOnlyGroup>>>> GetWeekData(DateTime dateAtThisWeek)
        {
            Dictionary<Tuple<DateTime, LessonsOrder>, IReadOnlyList<Tuple<IRoom, IReadOnlyList<IReadOnlyTeacher>, IReadOnlyList<IReadOnlyGroup>>>> weekSchedule = new Dictionary<Tuple<DateTime, LessonsOrder>, IReadOnlyList<Tuple<IRoom, IReadOnlyList<IReadOnlyTeacher>, IReadOnlyList<IReadOnlyGroup>>>>();

            DateTime dateFrom = new DateTime(dateAtThisWeek.Year, dateAtThisWeek.Month, dateAtThisWeek.Day);
            DateTime dateTo = new DateTime(dateAtThisWeek.Year, dateAtThisWeek.Month, dateAtThisWeek.Day + 7);

            List<DateTime> week = new List<DateTime>();

            for (int i = 0; i < dateTo.Day; i++)
            {
                week.Add(new DateTime(dateAtThisWeek.Year, dateAtThisWeek.Month, dateAtThisWeek.Day + i));
            }

            var t = from item in items
                    from w in week
                    where item.Key == w
                    from schedItem in item.Value
                    from si in schedItem.Teachers
                    select si;

            var g = from item in items
                    from w in week
                    where item.Key == w
                    from schedItem in item.Value
                    from si in schedItem.Groups
                    select si;

            var r = from item in items
                    from w in week
                    where item.Key == w
                    from schedItem in item.Value
                    select schedItem.Room;

            IReadOnlyList<IReadOnlyTeacher> teachersNames = (IReadOnlyList<IReadOnlyTeacher>)t;
            IReadOnlyList<IReadOnlyGroup> groupsNames = (IReadOnlyList<IReadOnlyGroup>)g;
            IReadOnlyList<IRoom> roomsList = (IReadOnlyList<IRoom>)r;

            foreach (var lt in lessonsTime)
                    foreach (var rl in roomsList)
                    {
                        Tuple<IRoom, IReadOnlyList<IReadOnlyTeacher>, IReadOnlyList<IReadOnlyGroup>> tupleTemp = Tuple.Create(rl, teachersNames, groupsNames);
                        List<Tuple<IRoom, IReadOnlyList<IReadOnlyTeacher>, IReadOnlyList<IReadOnlyGroup>>> tempList = new List<Tuple<IRoom, IReadOnlyList<IReadOnlyTeacher>, IReadOnlyList<IReadOnlyGroup>>>();
                        tempList.Add(tupleTemp);
                        weekSchedule.Add(Tuple.Create(lt.Value, lt.Key), tempList);
                    }        
            
            return weekSchedule;        
        } 
    }
}
