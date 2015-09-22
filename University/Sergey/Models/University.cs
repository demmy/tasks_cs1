using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Sergey.Models
{
    class University: IUniversity
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
        private readonly IReadOnlyTeacher[] _teachers;
        private readonly IRoom[] _rooms;

        #endregion
        
        #region Ctors

        public University(string title)
        {
            _title = title;
            _schedule = new Schedule.Schedule();
            _rooms = new IRoom[0];
            _teachers = new IReadOnlyTeacher[0];
            _groups = new GroupDictionary();
        }

        public University(string title, ISchedule schedule)
        {
            _title = title;
            _schedule = schedule;
            _rooms = new IRoom[0];
            _teachers = new IReadOnlyTeacher[0];
            _groups = new GroupDictionary();
        }

        public University(string title, ISchedule schedule, IRoom[] rooms)
        {
            _title = title;
            _schedule = schedule;
            _rooms = rooms;
            _teachers = new IReadOnlyTeacher[0];
            _groups = new GroupDictionary();
        }

        public University(string title, ISchedule schedule, IRoom[] rooms, IReadOnlyTeacher[] teachers)
        {
            _title = title;
            _schedule = schedule;
            _rooms = rooms;
            _teachers = teachers;
            _groups = new GroupDictionary();
        }

        #endregion


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
    }
}
