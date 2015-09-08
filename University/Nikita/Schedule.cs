using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Nikita
{
    internal class Schedule : ISchedule
    {
        private Dictionary<DateTime, List<ScheduleItem>> _items;

        public Schedule(Dictionary<DateTime, List<ScheduleItem>> items)
        {
            _items = items;
        }

        /// <returns>list of lessons data per room: name of room, list of data: time of start, 
        /// list of names of teachers, list of group names.</returns>
        public IReadOnlyDictionary<string, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>
            GetByDay(DateTime day)
        {
            var perRoomDict =
                new Dictionary<string, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>();
            foreach (var pair in _items)
            {
                if (pair.Key != day) continue;
                foreach (var item in pair.Value)
                {
                    if (perRoomDict.ContainsKey(item.Room.Id))
                    {
                        var tuplesList = new List<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>();
                        tuplesList.AddRange(perRoomDict.SelectMany(list => list.Value));
                        tuplesList.Add(
                            new Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>(
                                ScheduleItem.DateLessonTimes[item.Order],
                                item.Teachers.Select(t => t.FullName).ToList(),
                                item.Groups.Select(g => g.ID).ToList()));
                        perRoomDict[item.Room.Id] = tuplesList;
                    }
                    else
                    {
                        var tuplesList = new List<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>
                        {
                            new Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>(
                                ScheduleItem.DateLessonTimes[item.Order],
                                item.Teachers.Select(t => t.FullName).ToList(),
                                item.Groups.Select(g => g.ID).ToList())
                        };
                        perRoomDict[item.Room.Id] = tuplesList;
                    }
                }
            }
            return perRoomDict;
        }

        /// <returns>list of lessons data per day per room: date, name of room, 
        /// list of data: time of start, list of names of teacher, list of group names.</returns>
        public
            IReadOnlyDictionary
                <DateTime,
                    IReadOnlyDictionary
                        <string, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>> GetAll()
        {
            var perDateDict =
                new Dictionary
                    <DateTime,
                        IReadOnlyDictionary
                            <string, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>>();
            foreach (var pair in _items)
            {
                var perRoomDict =
                    new Dictionary<string, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>
                        ();
                foreach (var item in pair.Value)
                {
                    if (perRoomDict.ContainsKey(item.Room.Id))
                    {
                        var tuplesList =
                            (List<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>)
                                perRoomDict[item.Room.Id];
                        tuplesList.Add(
                            new Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>(
                                ScheduleItem.DateLessonTimes[item.Order],
                                item.Teachers.Select(t => t.FullName).ToList(),
                                item.Groups.Select(g => g.ID).ToList()));
                    }
                    else
                    {
                        var tuplesList = new List<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>
                        {
                            new Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>(
                                ScheduleItem.DateLessonTimes[item.Order],
                                item.Teachers.Select(t => t.FullName).ToList(),
                                item.Groups.Select(g => g.ID).ToList())
                        };
                        perRoomDict.Add(item.Room.Id, tuplesList);
                    }
                }
                perDateDict.Add(pair.Key, perRoomDict);
            }
            return perDateDict;
        }

        /// <param name="roomName"></param>
        /// <returns>list of lessons data per day: date, list of data: time of start, list of names of teacher, list of group names</returns>

        public
            IReadOnlyDictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>
            GetByRoom(string roomName)
        {
            var perDateDict =
                new Dictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>();
            foreach (var pair in _items)
            {
                foreach (var item in pair.Value)
                {
                    if (item.Room.Id == roomName)
                    {
                        if (perDateDict.ContainsKey(pair.Key))
                        {
                            var tuplesList =
                                (List<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>)
                                    perDateDict[pair.Key];
                            tuplesList.Add(new Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>(
                                ScheduleItem.DateLessonTimes[item.Order],
                                item.Teachers.Select(t => t.FullName).ToList(),
                                item.Groups.Select(g => g.ID).ToList()));
                            perDateDict.Add(pair.Key, tuplesList);
                        }
                        else
                        {
                            var tuplesList = new List<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>()
                            {
                                new Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>(
                                    ScheduleItem.DateLessonTimes[item.Order],
                                    item.Teachers.Select(t => t.FullName).ToList(),
                                    item.Groups.Select(g => g.ID).ToList())
                            };
                            perDateDict.Add(pair.Key, tuplesList);
                        }
                    }
                }
            }
            return perDateDict;
        }

        /// <param name="groupName"></param>
        /// <returns>list of lessons data per day: list of data: date, time of start, list of names of teacher, flag if this is multiple group lesson</returns>
        public IReadOnlyDictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, bool>>> GetByGroup(
            string groupName)
        {
            var perDateDict = new Dictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, bool>>>();
            foreach (var pair in _items)
            {
                foreach (var item in pair.Value)
                {
                    foreach (var group in item.Groups)
                    {
                        if (group.ID == groupName)
                        {
                            if (perDateDict.ContainsKey(pair.Key))
                            {
                                var tuplesList =
                                    (List<Tuple<DateTime, IReadOnlyList<string>, bool>>) perDateDict[pair.Key];
                                tuplesList.Add(
                                    new Tuple<DateTime, IReadOnlyList<string>, bool>(
                                        ScheduleItem.DateLessonTimes[item.Order],
                                        item.Teachers.Select(t => t.FullName).ToList(), item.Groups.Count() > 1));
                            }
                            else
                            {
                                var tuplesList = new List<Tuple<DateTime, IReadOnlyList<string>, bool>>()
                                {
                                    new Tuple<DateTime, IReadOnlyList<string>, bool>(
                                        ScheduleItem.DateLessonTimes[item.Order],
                                        item.Teachers.Select(t => t.FullName).ToList(), item.Groups.Count() > 1)
                                };
                            }
                        }
                    }
                }
            }
            return perDateDict;
        }

        /// <param name="teacherName"></param>
        /// <returns>list of lessons data per day: date, list of data: time of start, name of room, list of group names</returns>
        public IReadOnlyDictionary<DateTime, IReadOnlyList<Tuple<DateTime, string, IReadOnlyList<string>>>> GetByTeacher
            (string teacherName)
        {
            var perDateDict = new Dictionary<DateTime, IReadOnlyList<Tuple<DateTime, string, IReadOnlyList<string>>>>();
            foreach (var pair in _items)
            {
                foreach (var item in pair.Value)
                {
                    foreach (var teacher in item.Teachers)
                    {
                        if (teacher.FullName == teacherName)
                        {
                            if (perDateDict.ContainsKey(pair.Key))
                            {
                                var tuplesList =
                                    (List<Tuple<DateTime, string, IReadOnlyList<string>>>) perDateDict[pair.Key];
                                tuplesList.Add(
                                    new Tuple<DateTime, string, IReadOnlyList<string>>(
                                        ScheduleItem.DateLessonTimes[item.Order],
                                        item.Room.Id, item.Groups.Select(g => g.ID).ToList()));
                            }
                            else
                            {
                                var tuplesList = new List<Tuple<DateTime, string, IReadOnlyList<string>>>()
                                {
                                    new Tuple<DateTime, string, IReadOnlyList<string>>(
                                        ScheduleItem.DateLessonTimes[item.Order],
                                        item.Room.Id, item.Groups.Select(g => g.ID).ToList())
                                };
                            }
                        }
                    }
                }
            }
            return perDateDict;
        }

        public IEnumerable<DateTime> AllExistingDates
        {
            get { return _items.Keys; }
        }

        public IReadOnlyDictionary<Tuple<DateTime, LessonsOrder>, IReadOnlyList<Tuple<IRoom, IReadOnlyList<IReadOnlyTeacher>, IReadOnlyList<IReadOnlyGroup>>>>
            GetWeekData(DateTime dateAtThisWeek)
        {
            var startOfWeek = GetStartOfWeek(dateAtThisWeek);
            var datesOfWeek = new List<DateTime>();
            for (int i = 1; i < 8; i++)
            {
                datesOfWeek.Add(startOfWeek.AddDays(i));
            }
            var returnDict = new Dictionary<Tuple<DateTime, LessonsOrder>, IReadOnlyList<Tuple<IRoom, IReadOnlyList<IReadOnlyTeacher>, IReadOnlyList<IReadOnlyGroup>>>>();
            foreach (var date in datesOfWeek)
            {
                foreach (var item in _items[date])
                {
                    var tuplesList = new List<Tuple<IRoom, IReadOnlyList<IReadOnlyTeacher>, IReadOnlyList<IReadOnlyGroup>>>()
                    {
                        new Tuple<IRoom, IReadOnlyList<IReadOnlyTeacher>, IReadOnlyList<IReadOnlyGroup>>(item.Room, (IReadOnlyList<IReadOnlyTeacher>) item.Teachers,
                            (IReadOnlyList<IReadOnlyGroup>) item.Groups)
                    };
                    returnDict.Add(new Tuple<DateTime, LessonsOrder>(date, item.Order), tuplesList);
                }
            }
            return returnDict;
        }

        private static DateTime GetStartOfWeek(DateTime dateAtThisWeek)
        {
            return dateAtThisWeek.AddDays(-((int) dateAtThisWeek.DayOfWeek));
        }
    }
}
