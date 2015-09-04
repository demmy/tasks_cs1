using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Tatyana
{
    class Group : IReadOnlyGroup
    {
        List<Student> students;
        FacultyType faculty;
        string id;
        static Dictionary<Tuple<int, string>, int> existingGroupsCount;
        


        public string ID
        {
            get { return id; }
        }

        public FacultyType Faculty
        {
            get { return faculty; }
        }

        public  IEnumerable<IReadOnlyPerson> Students
        {
            get {
                foreach (Student s in students)
                         yield return s;
                }
        }

        public Group(FacultyType f, int year, string speciality)
        {
            faculty = f;
            Tuple<int, string> t = new Tuple<int, string>(year, speciality);
            if (!existingGroupsCount.ContainsKey(t))
            {
                existingGroupsCount[t] = 0;
            }
            existingGroupsCount[t]++;
            id = string.Format("{0}-{1}-{2}", speciality, (year % 100), 
                 existingGroupsCount[t] );
            
        }

        private string Shifr(string a)
        {
            int i = 1;
            while (i <= 9)
            {
                if (object.Equals(string.Format("{0}", (SpecialityTitle)i), a))
                {
                    break;
                }
                i++;
            }
            string[] shifr = new string[] { "AP", "CSe", "CSy",
                        "En", "Gr", "Mn", "Mr",  "QP", "None" };
            return shifr[i - 1];
        }

        public void Add(Student s)
        {
            students.Add(s);
        }

        
    }
}
