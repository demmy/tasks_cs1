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
        static Dictionary<Tuple<int, string>, int> existingGroupsCount=new Dictionary<Tuple<int,string>,int>();
        


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
                return students;
                //foreach (Student s in students)
                //    yield return s;
                
                }
        }
        public void Add(Student s)
        {
            students.Add(s);
        }

        public void AddStudents(IEnumerable<Student> s)
        {
            students.AddRange(s);
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
            id = string.Format("{0}-{1}-{2}", speciality, string.Format("{0}{1}", (year % 100) > 9 ? "0" : "", year % 100), existingGroupsCount[t]);
            id = string.Format("{0}-{1}-{2}", Shifr(speciality), string.Format("{0}{1}", (year % 100) <=9 ? "0" : "", year % 100),
                                                                 existingGroupsCount[t]);
            students = new List<Student>();
            
        } 

        public string Shifr(string a)
        {
            int i = 0;
            while (i < 8)
            {
                if (object.Equals(string.Format("{0}", (SpecialityTitle)i), a))
                {
                    break;
                }

                i++;
            }

            string[] shifr = new string[] {  "CSe", "CSy",
                         "Mn", "Mr", "QP", "AP",   "En", "Gr" , "None" };
            return shifr[i];
        }
        

        

        
    }
}
