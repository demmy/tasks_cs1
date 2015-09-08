using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Nikita
{
    class University : IUniversity
    {
        private List<Group> _groups;
        private List<Teacher> _teachers;
        public List<Room> Rooms { get; private set; }
        private Schedule _schedule;
        public string Name { get; private set; }

        public University(string title)
        {
            Name = title;
            _groups = new List<Group>();
            Rooms = new List<Room>();
           // _schedule = new Schedule();
            _teachers = new List<Teacher>();
        }

        public void Add(Student s)
        {
            foreach (var g in _groups)
            {
                if (s.CompareGroup(g.ID))
                {
                    g.Add(s);
                }
            }
        }

        public void Add(Teacher t)
        {
            if(t!=null) _teachers.Add(t);
        }

        public void Add(Room r)
        {
            if(r!=null) Rooms.Add(r);
        }

        public ISchedule CurrentSchedule
        {
            get { return _schedule; }
        }

        public IReadOnlyList<string> RoomsNames
        {
            get { return (from r in Rooms select r.Id).ToList(); }
        }

        public IReadOnlyList<string> TeachersNames
        {
            get { return (from t in _teachers select t.FullName).ToList(); }
        }

        public IReadOnlyList<string> GroupsNames
        {
            get { return (from g in _groups select g.ID).ToList(); }
        }

        public IReadOnlyList<string> GetStudentsNames(string groupName)
        {
             return (from g in _groups where g.ID==groupName from s in g.Students select s.FullName).ToList();
        }
    }
}
