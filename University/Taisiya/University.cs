using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Taisiya
{
    class University: IUniversity
    {
        private string Title;
        private Schedule schedule;
        private List<IReadOnlyTeacher> Teachers;
        private List<IReadOnlyGroup> Groups; 
        private List<Room> Rooms;
        

        public University(string Title)
        {
            this.Title = Title;
            Rooms = new List<Room>();
            Teachers = new List<IReadOnlyTeacher>();
            Groups = new List<IReadOnlyGroup>();
        }

        public ISchedule CurrentSchedule
        {
            get 
            {          
                return schedule; 
            }
        }

        public IReadOnlyList<string> RoomsNames
        {
            get 
            { 
                var roomsNames = Rooms.Select(x => x.Id).ToList();
                return roomsNames;
            }
        }

        public IReadOnlyList<string> TeachersNames
        {
            get  
            { 
                var teachersNames = Teachers.Select(x => x.FullName).ToList();
                return teachersNames;
            }
        }

        public IReadOnlyList<string> GroupsNames
        {
            get
            {
                var groupsNames = Groups.Select(x => x.ID).ToList();
                return groupsNames;
            }
        }

        public IReadOnlyList<string> GetStudentsNames(string groupName)
        {
            var s = from gr in Groups
                    where gr.ID == groupName
                    from st in gr.Students
                    select st.FullName;

            IReadOnlyList<string> studentsNames = (IReadOnlyList<string>)s;

            return studentsNames;
        }
    }
}
