using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Nikita
{
    class ScheduleItem
    {
        public LessonsOrder Order { get; private set; }
        public Room Room { get; private set; }
        public IEnumerable<Teacher> Teachers { get; private set; }
        public IEnumerable<Group> Groups { get; private set; }

        public static Dictionary<LessonsOrder, DateTime> DateLessonTimes
        {
            get { return _dateLessonTimes; }
        }

        private static Dictionary<LessonsOrder, DateTime> _dateLessonTimes = new Dictionary<LessonsOrder, DateTime>()
        {
            {
                LessonsOrder.FirstLesson, new DateTime(2000, 1, 1, 8, 0, 0)
            },
            {
                LessonsOrder.SecondLesson, new DateTime(2000, 1, 1, 9, 30, 0)
            },
            {
                LessonsOrder.ThirdLesson, new DateTime(2000, 1, 1, 11, 10, 0)
            },
            {
                LessonsOrder.FourthLesson, new DateTime(2000, 1, 1, 12, 40, 0)
            },
            {
                LessonsOrder.FifthLesson, new DateTime(2000, 1, 1, 14, 00, 0)
            },
            {
                LessonsOrder.SixthLesson, new DateTime(2000, 1, 1, 15, 30, 0)
            },
            {
                LessonsOrder.SeventhLesson, new DateTime(2000, 1, 17, 10, 0, 0)
            },
            {
                LessonsOrder.EighthLesson, new DateTime(2000, 1, 1, 18, 40, 0)
            },
        };

        public ScheduleItem(IEnumerable<Group> groups, LessonsOrder order, Room room, IEnumerable<Teacher> teachers)
        {
            Groups = groups;
            Order = order;
            this.Room = room;
            Teachers = teachers;
        }
    }
}
