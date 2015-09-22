using System;   
using System.Collections.Generic;
using University.Sergey.Models.Interfaces;

namespace University.Sergey.Models.Schedule
{
    partial class Schedule
    {
        private class ScheduleItem: IElementsManager<IReadOnlyTeacher>, IElementsManager<IReadOnlyGroup>
        {
            private readonly LessonsOrder _lesson;
            private readonly IRoom _room;
            private readonly List<IReadOnlyTeacher> _teachers;
            private readonly List<IReadOnlyGroup> _groups;

            #region Timing

            //Time format for parsing, just not to set the Date exactly, in good it should be TimeSpan, not DateTime - but no problem for us now
            private const string ParsingDateString = "HH:MM";
            //Lesson time long, it could be set from static ctor, where we should get the user set lesson time, by default it is 80 minutes
            private static byte LessonLength = 80;
            //In good way, the time should be set by user (not "8:00", but firstLessonTime variable)
            public static readonly IReadOnlyDictionary<LessonsOrder, DateTime> DateLessonRelation =
                new Dictionary<LessonsOrder, DateTime>
                {
                    {
                        LessonsOrder.FirstLesson, DateTime.ParseExact("8:00", ParsingDateString, null)
                        /*new DateTime(2000, 1, 1, 8, 0, 0)*/
                    },
                    {
                        LessonsOrder.SecondLesson, DateTime.ParseExact("9:30", ParsingDateString, null)
                        /*new DateTime(2000, 1, 1, 9, 30, 0)*/
                    },
                    {
                        LessonsOrder.ThirdLesson, DateTime.ParseExact("11:10", ParsingDateString, null)
                        /*new DateTime(2000, 1, 1, 11, 10, 0)*/
                    },
                    {
                        LessonsOrder.FourthLesson, DateTime.ParseExact("12:40", ParsingDateString, null)
                        /*new DateTime(2000, 1, 1, 12, 40, 0)*/
                    },
                    {
                        LessonsOrder.FifthLesson, DateTime.ParseExact("14:00", ParsingDateString, null)
                        /*new DateTime(2000, 1, 1, 14, 00, 0)*/
                    },
                    {
                        LessonsOrder.SixthLesson, DateTime.ParseExact("15:30", ParsingDateString, null)
                        /*new DateTime(2000, 1, 1, 15, 30, 0)*/
                    },
                    {
                        LessonsOrder.SeventhLesson, DateTime.ParseExact("17:10", ParsingDateString, null)
                        /*new DateTime(2000, 1, 17, 10, 0, 0)*/
                    },
                    {
                        LessonsOrder.EighthLesson, DateTime.ParseExact("18:40", ParsingDateString, null)
                        /*new DateTime(2000, 1, 1, 18, 40, 0)*/
                    }
                };

            #endregion

            public ScheduleItem(LessonsOrder lesson, IRoom room)
            {
                _lesson = lesson;
                _room = room;
                _teachers = new List<IReadOnlyTeacher>();
                _groups = new List<IReadOnlyGroup>();
            }

            public ScheduleItem(LessonsOrder lesson, IRoom room, IEnumerable<IReadOnlyTeacher> teachers, IEnumerable<IReadOnlyGroup> groups)
            {
                _lesson = lesson;
                _room = room;
                _teachers.AddRange(teachers);
                _groups.AddRange(groups);
            }

            public IReadOnlyList<IReadOnlyGroup> Groups
            {
                get { return _groups; }
            }

            public IReadOnlyList<IReadOnlyTeacher> Teachers
            {
                get { return _teachers; }
            }

            public LessonsOrder Lesson
            {
                get { return _lesson; }
            }

            public IRoom Room
            {
                get { return _room; }
            }

            public void Add(IReadOnlyTeacher item)
            {
                _teachers.Add(item);
            }

            public void AddRange(IEnumerable<IReadOnlyTeacher> items)
            {
                _teachers.AddRange(items);
            }

            public void Remove(IReadOnlyTeacher item)
            {
                _teachers.Add(item);
            }

            public void Add(IReadOnlyGroup item)
            {
                _groups.Add(item);
            }

            public void AddRange(IEnumerable<IReadOnlyGroup> items)
            {
                _groups.AddRange(items);
            }

            public void Remove(IReadOnlyGroup item)
            {
                _groups.Add(item);
            }
        }
    }
}
