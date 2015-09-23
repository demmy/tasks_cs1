using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Taisiya
{
    class Group
    {
        private string GroupTitle;
        private int StudentsNumber;

        public Group(string GroupTitle, int StudentsNumber)
        {
            this.GroupTitle = GroupTitle;
            this.StudentsNumber = StudentsNumber;
        }

        public string Title
        {
            get { return GroupTitle; }
        }

        public int Number
        {
            get { return StudentsNumber; }
        }
    }
}
