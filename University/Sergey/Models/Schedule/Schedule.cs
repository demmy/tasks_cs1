using System;
using System.Collections.Generic;
using System.Linq;

namespace University.Sergey.Models.Schedule
{
    partial class Schedule: ISchedule
    {
        private readonly IDictionary<DateTime, List<ScheduleItem>> _items;

        public Schedule()
        {
            _items = new Dictionary<DateTime, List<ScheduleItem>>();
        }
        public IReadOnlyDictionary<string, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>> GetByDay(DateTime day)
        {
            //if (!_items.ContainsKey(day))
            //    throw new KeyNotFoundException();
            //If there is no such day in collection it should return an empty collection
            var grouping = 
                from @item in _items
                    from @scheduleItem in item.Value
                        where item.Key == day

                    group new Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>
                        (ScheduleItem.DateLessonRelation[scheduleItem.Lesson],
                        scheduleItem.Groups.Select(currrentGroup => currrentGroup.ID).ToList(),
                        scheduleItem.Teachers.Select(teacher => teacher.FullName).ToList()) by scheduleItem.Room.Id;

            return grouping.ToDictionary(gr => gr.Key, value => (IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>)value.ToList());
        }

        public IReadOnlyDictionary<DateTime, IReadOnlyDictionary<string, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>> GetAll()
        {
            var dict = (from @item in _items
                           let @list = (from scheduleItem in item.Value
                                          group 
                                          new Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>
                                            (ScheduleItem.DateLessonRelation[scheduleItem.Lesson],
                                            scheduleItem.Groups.Select(gr => gr.ID).ToList(),
                                            scheduleItem.Teachers.Select(tch => tch.FullName).ToList())

                                                by scheduleItem.Room.Id)
                                                .ToDictionary(x => x.Key, y => (IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>)y.ToList())

                        select new KeyValuePair<DateTime, IReadOnlyDictionary<string, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>>(item.Key, list))
                        .ToDictionary(a => a.Key, b => b.Value)   ;

            return dict;
        }

        public IReadOnlyDictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>> GetByRoom(string roomName)
        {
            var grouping =
                (from @item in _items
                    from @scheduleItem in item.Value
                        where scheduleItem.Room.Id == roomName

                 group new Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>
                     (ScheduleItem.DateLessonRelation[scheduleItem.Lesson],
                     scheduleItem.Groups.Select(currrentGroup => currrentGroup.ID).ToList(),
                         scheduleItem.Teachers.Select(teacher => teacher.FullName).ToList()) by item.Key);

            return grouping.ToDictionary(day => day.Key, value => (IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>)
                                                                            value.ToList());
        }

        public IReadOnlyDictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, bool>>> GetByGroup(string groupName)
        {
            var grouping = 
                (from @item in _items
                    from @scheduleItem in item.Value
                        from @groupOfStudents in scheduleItem.Groups
                            where groupOfStudents.ID == groupName

                group new Tuple<DateTime, IReadOnlyList<string>, bool>
                    (ScheduleItem.DateLessonRelation[scheduleItem.Lesson],
                        scheduleItem.Teachers.Select(teacher => teacher.FullName).ToList(),
                        scheduleItem.Groups.Count() > 1) by item.Key);

            return grouping.ToDictionary(day => day.Key, value => (IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, bool>>)
                                                                value.ToList());
            //What? List<T> can not be converted to IReadOnlyList<T>, maybe it's because of it's inner collection
            //Right, lets do this explicitly
        }

        public IReadOnlyDictionary<DateTime, IReadOnlyList<Tuple<DateTime, string, IReadOnlyList<string>>>> GetByTeacher(string teacherName)
        {
            var grouping =
                 (from @item in _items
                    from @scheduleItem in item.Value

                  group new Tuple<DateTime, string, IReadOnlyList<string>>
                      (ScheduleItem.DateLessonRelation[scheduleItem.Lesson],
                          scheduleItem.Room.Id,
                          scheduleItem.Groups.Select(currrentGroup => currrentGroup.ID).ToList()) by item.Key);

            return grouping.ToDictionary(day => day.Key, value => (IReadOnlyList<Tuple<DateTime, string, IReadOnlyList<string>>>)
                                                                value.ToList());
        }

        public IEnumerable<DateTime> AllExistingDates
        {
            get { return _items.Keys; }
        }

        public IReadOnlyDictionary<Tuple<DateTime, LessonsOrder>, IReadOnlyList<Tuple<IRoom, IReadOnlyList<IReadOnlyTeacher>, IReadOnlyList<IReadOnlyGroup>>>> GetWeekData(DateTime dateAtThisWeek)
        {
            DateTime loopTime = dateAtThisWeek;
            while (loopTime.DayOfWeek != DayOfWeek.Monday)
                loopTime = loopTime.AddDays(-1);

            var grouping = from @item in _items
                                where item.Key >= loopTime && item.Key < loopTime.AddDays(7)
                                    from @scheduleItem in item.Value

                    group new Tuple<IRoom, IReadOnlyList<IReadOnlyTeacher>, IReadOnlyList<IReadOnlyGroup>>
                            (scheduleItem.Room,
                            scheduleItem.Teachers.ToList(),
                            scheduleItem.Groups.ToList())
                           
                    by new Tuple<DateTime, LessonsOrder>(item.Key, scheduleItem.Lesson)

            ;
            return grouping.ToDictionary(dateOrder => dateOrder.Key, data => (IReadOnlyList<Tuple<IRoom, IReadOnlyList<IReadOnlyTeacher>, IReadOnlyList<IReadOnlyGroup>>>)data.ToList());
        }
    }
}
