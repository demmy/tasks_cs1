using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Nikita
{
    internal class Group : IReadOnlyGroup
    {
        private List<Student> _students;
        private static Dictionary<Tuple<int, string>, int> _existingGroupsCount = new Dictionary<Tuple<int, string>, int>();

        public string ID { get; private set; }

        public FacultyType Faculty { get; private set; }

        public IEnumerable<IReadOnlyPerson> Students
        {
            get { return _students; }
        }

        public Group(FacultyType f, int year, string speciality)
        {
            Faculty = f;
            ID = year + " " + speciality;
            _students=new List<Student>();
            if (_existingGroupsCount.ContainsKey(new Tuple<int, string>(year, speciality)))
            {
                _existingGroupsCount[new Tuple<int, string>(year, speciality)]++;
            }
            else
            {
                _existingGroupsCount.Add(new Tuple<int, string>(year, speciality), 1);
            }
        }

        public void Add(Student s)
        {
            if(s!=null) _students.Add(s);
        }
    }

}
