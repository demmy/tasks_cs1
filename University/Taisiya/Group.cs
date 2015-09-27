using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Taisiya
{
    class Group: IReadOnlyGroup
    {
        private string id;
        private FacultyType faculty;
        private IEnumerable<IReadOnlyPerson> students;
        private int year;
        SpecialityTitle speciality;
        private static Dictionary<string, int> existingGroupsCount;
        private int count;

        public Group(FacultyType faculty, SpecialityTitle speciality, int year)
        {
            this.faculty = faculty;
            this.speciality = speciality;
            this.year = year;
                      
            foreach (var ec in existingGroupsCount.Keys)
            {
                if (Title != ec)
                    count = 1;
                else
                    count++;
            }
            existingGroupsCount.Add(Title, count);
        }

        public string Title
        {
            get 
            {
                string name = Speciality.ToString().Select(x => Char.IsUpper(x)).ToString()
                    + Faculty.ToString().Select(x => Char.IsUpper(x)).ToString() 
                    + "-" + year.ToString()[2] + year.ToString()[3];               

                return name; 
            }
        }

        public string ID
        {
            get 
            {                           
                return ID + " - " + count; 
            }
        }

        public SpecialityTitle Speciality
        {
            get { return speciality; }
        }

        public FacultyType Faculty
        {
            get { return faculty; }
        }

        public IEnumerable<IReadOnlyPerson> Students
        {
            get { return students; }
        }

        public void Add(Student s)
        {
            students.ToList().Add((IReadOnlyPerson)s);
        }
    }
}
