using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Sergey.Models
{
    class University:IUniversity
    {
        public ISchedule CurrentSchedule { get; private set; }
        public IReadOnlyList<string> RoomsNames { get; private set; }
        public IReadOnlyList<string> TeachersNames { get; private set; }
        public IReadOnlyList<string> GroupsNames { get; private set; }
        public IReadOnlyList<string> GetStudentsNames(string groupName)
        {
            throw new NotImplementedException();
        }
    }
}
