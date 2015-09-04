using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    enum LessonsOrder { ZeroLesson = 0, FirstLesson, SecondLesson, ThirdLesson, FourthLesson,
        FifthLesson, SixthLesson, SeventhLesson, EighthLesson };

    interface ISchedule
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="day"></param>
        /// <returns>list of lessons data per room: name of room, list of data: time of start, 
        /// list of names of teachers, list of group names.</returns>
        IReadOnlyDictionary<string, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>> GetByDay(DateTime day);

        /// <summary>
        /// 
        /// </summary>
        /// <returns>list of lessons data per day per room: date, name of room, 
        /// list of data: time of start, list of names of teacher, list of group names.</returns>
        IReadOnlyDictionary<DateTime, IReadOnlyDictionary<string, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>> GetAll();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="roomName"></param>
        /// <returns>list of lessons data per day: date, list of data: time of start, list of names of teacher, list of group names</returns>
        IReadOnlyDictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>> GetByRoom(string roomName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="groupName"></param>
        /// <returns>list of lessons data per day: list of data: date, time of start, list of names of teacher, flag if this is multiple group lesson</returns>
        IReadOnlyDictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, bool>>> GetByGroup(string groupName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="teacherName"></param>
        /// <returns>list of lessons data per day: date, list of data: time of start, name of room, list of group names</returns>
        IReadOnlyDictionary<DateTime, IReadOnlyList<Tuple<DateTime, string, IReadOnlyList<string>>>> GetByTeacher(string teacherName);

        IEnumerable<DateTime> AllExistingDates { get; }

        IReadOnlyDictionary<Tuple<DateTime, LessonsOrder>, IReadOnlyList<Tuple<IRoom, IReadOnlyList<IReadOnlyTeacher>, IReadOnlyList<IReadOnlyGroup>>>> GetWeekData(DateTime dateAtThisWeek);
    }
}
