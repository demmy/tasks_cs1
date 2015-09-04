using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Tatyana
{
    class ScheduleItem
    {
        //public LessonsOrder lesson;
        //public Room room;
        //public Teacher teacher;
        //public List<Group> groups;
        public LessonsOrder Lesson{get; set;}
        public Room Room{ get; set;}
        public Teacher Teacher{get; set;}
        public IEnumerable<Group> Groups{get; set;}

      
            

    }
}
