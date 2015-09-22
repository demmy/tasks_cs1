using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using University.Sergey.Models.Interfaces;

namespace University.Sergey.Models
{
    class University: IUniversity, IElementsManager<IReadOnlyTeacher>, IElementsManager<IRoom>, IElementsManager<IReadOnlyGroup>
    {
        #region Statics
        //The connection between Names of Faculties and their enums
        public static readonly IReadOnlyDictionary<FacultyType, string> FacultyNaming = new Dictionary
            <FacultyType, string>
        {
            {FacultyType.IT, "IT"},
            {FacultyType.Economics, "Economics"},
            {FacultyType.Languages, "Languages"},
            {FacultyType.Physics, "Physics"}
        };
        //The relation of hierarchy (speciality -> faculty)
        public static readonly IReadOnlyDictionary<string, IEnumerable<string>> FacultyToSpecialityRelations = new Dictionary
            <string, IEnumerable<string>>
        {
            {
                FacultyNaming[FacultyType.IT],
                new[] {"ComputerScience", "ComputerSecurity"}
            },
            {
                FacultyNaming[FacultyType.Economics],
                new[] {"Marketing", "Management"}
            },
            {
                FacultyNaming[FacultyType.Physics],
                new[] {"Applied Physics", "Quantum Physics"}
            },
            {
                FacultyNaming[FacultyType.Languages],
                new[] {"English", "German"}
            }
        };
        //TODO: find better solution than using lts of static dictionary, have a closer look to some patterns
        #endregion

        #region Inner Classes

        private class GroupDictionary : KeyedCollection<string, IReadOnlyGroup>
        {

            protected override string GetKeyForItem(IReadOnlyGroup item)
            {
                return item.ID;
            }
        }

        #endregion

        #region Private Fields

        private string _title;
        private readonly ISchedule _schedule;

        private readonly GroupDictionary _groups;
        private readonly List<IReadOnlyTeacher> _teachers;
        private readonly List<IRoom> _rooms;

        #endregion
        
        #region Ctors

        public University(string title)
        {
            _title = title;
            _schedule = new Schedule.Schedule();
            _rooms = new List<IRoom>();
            _teachers = new List<IReadOnlyTeacher>();
            _groups = new GroupDictionary();
        }

        public University(string title, ISchedule schedule)
        {
            _title = title;
            _schedule = schedule;
            _rooms = new List<IRoom>();
            _teachers = new List<IReadOnlyTeacher>();
            _groups = new GroupDictionary();
        }

        public University(string title, ISchedule schedule, IRoom[] rooms)
        {
            _title = title;
            _schedule = schedule;
            _rooms.AddRange(rooms);
            _teachers = new List<IReadOnlyTeacher>();
            _groups = new GroupDictionary();
        }

        public University(string title, ISchedule schedule, IRoom[] rooms, IReadOnlyTeacher[] teachers)
        {
            _title = title;
            _schedule = schedule;
            _rooms.AddRange(rooms);
            _teachers.AddRange(teachers);
            _groups = new GroupDictionary();
        }

        #endregion

        public void AddLesson(DateTime date, LessonsOrder lesson, Room room, IEnumerable<Teacher> teachers,
            IEnumerable<Group> groups)
        {
            var schedule = _schedule as Schedule.Schedule;
            if (schedule != null)
                schedule.AddLesson(date, lesson, room, teachers, groups);
        }

        public ISchedule CurrentSchedule
        {
            get { return _schedule; }
        }

        public IReadOnlyList<string> RoomsNames
        {
            get { return (from @room in _rooms select @room.Id).ToList(); }
        }

        public IReadOnlyList<string> TeachersNames
        {
            get { return (from @teacher in _teachers select @teacher.FullName).ToList(); }
        }

        public IReadOnlyList<string> GroupsNames {
            get { return (from @group in _groups select @group.ID).ToList(); }}

        public string Title
        {
            get { return _title; }
        }

        public IReadOnlyList<string> GetStudentsNames(string groupName)
        {
            return (from @student in _groups[groupName].Students select @student.FullName).ToList();
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
            _teachers.Remove(item);
        }

        public void Add(IRoom item)
        {
            _rooms.Add(item);
        }

        public void AddRange(IEnumerable<IRoom> items)
        {
            _rooms.AddRange(items);
        }

        public void Remove(IRoom item)
        {
            _rooms.Remove(item);
        }

        public void Add(IReadOnlyGroup item)
        {
            _groups.Add(item);
        }

        public void AddRange(IEnumerable<IReadOnlyGroup> items)
        {
            foreach (IReadOnlyGroup @group in items)
                _groups.Add(group);
        }

        public void Remove(IReadOnlyGroup item)
        {
            _groups.Add(item);
        }
    }
}
