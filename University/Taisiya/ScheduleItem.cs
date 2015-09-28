using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Taisiya
{
    class ScheduleItem
    {
        private LessonsOrder lesson;
        private IEnumerable<Teacher> teachers;
        private IEnumerable<Group> groups;
        private Room room;

        public ScheduleItem(LessonsOrder lo, IEnumerable<Teacher> t, IEnumerable<Group> g, Room r)
        {
            lesson = lo;
            teachers = t;
            groups = g;
            room = r;
        }

        public LessonsOrder Lesson
        {
            get { return lesson; }
        }

        public Room Room
        {
            get { return room; }
        }

        public IEnumerable<Teacher> Teachers
        {
            get { return teachers; }
        }

        public IEnumerable<Group> Groups
        {
            get { return groups; }
        }

    }
}
