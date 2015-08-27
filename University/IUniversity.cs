using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    interface IUniversity
    {
        ISchedule CurrentSchedule { get; }

        /// <summary>
        /// list of names of rooms
        /// </summary>
        IReadOnlyList<string> RoomsNames { get; }

        /// <summary>
        /// list of names of teachers
        /// </summary>
        IReadOnlyList<string> TeachersNames { get; }

        /// <summary>
        /// list of names of groups
        /// </summary>
        IReadOnlyList<string> GroupsNames { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="groupName"></param>
        /// <returns>list of names of students</returns>
        IReadOnlyList<string> GetStudentsNames(string groupName);
    }
}
