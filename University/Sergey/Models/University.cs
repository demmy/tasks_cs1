using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Sergey.Models
{
    class University: IUniversity
    {
        #region Statics

        public static readonly IReadOnlyDictionary<FacultyType, string> FacultyNaming = new Dictionary
            <FacultyType, string>
        {
            {FacultyType.IT, "IT"},
            {FacultyType.Economics, "Economics"},
            {FacultyType.Languages, "Languages"},
            {FacultyType.Physics, "Physics"}
        };

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

        #endregion
        private string _title;
        private ISchedule _schedule;
        
        private static IReadOnlyGroup[] _groups;
        private static IReadOnlyTeacher[] _teachers;
        private static IRoom[] _rooms;
        public University(string title)
        {
            _title = title;
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

        public IReadOnlyList<string> GetStudentsNames(string groupName)
        {

        }
    }
}
