using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    interface ISchedule
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="day"></param>
        /// <returns>list of lessons data per room: name of room, time of start, 
        /// name of teacher, list of group names.</returns>
        IReadOnlyDictionary<string, Tuple<DateTime, string, IReadOnlyList<string>>> GetByDay(DateTime day);

        /// <summary>
        /// 
        /// </summary>
        /// <returns>list of lessons data per day per room: date, name of room, 
        /// time of start, name of teacher, list of group names.</returns>
        IReadOnlyDictionary<DateTime, IReadOnlyDictionary<string, Tuple<DateTime, string, IReadOnlyList<string>>>> GetAll();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="roomName"></param>
        /// <returns>list of lessons data per day: date, time of start, name of teacher, list of group names</returns>
        IReadOnlyDictionary<DateTime, Tuple<DateTime, string, IReadOnlyList<string>>> GetByRoom(string roomName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="groupName"></param>
        /// <returns>list of lessons data per day: date, time of start, name of teacher, flag if this is multiple group lesson</returns>
        IReadOnlyDictionary<DateTime, Tuple<DateTime, string, bool>> GetByGroup(string groupName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="teacherName"></param>
        /// <returns>list of lessons data per day: date, time of start, name of room, list of group names</returns>
        IReadOnlyDictionary<DateTime, Tuple<DateTime, string, IReadOnlyList<string>>> GetByTeacher(string teacherName);

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
