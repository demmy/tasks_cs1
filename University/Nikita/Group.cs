using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace University.Nikita
{
    internal class Group : IReadOnlyGroup
    {
        private List<Student> _students = new List<Student>();
        private static readonly Dictionary<Tuple<int, string>, int> ExistingGroupsCount = new Dictionary<Tuple<int, string>, int>();

        public string ID { get; private set; }

        public FacultyType Faculty { get; private set; }

        public IEnumerable<IReadOnlyPerson> Students
        {
            get { return _students; }
        }

        public Group(FacultyType f, int year, string speciality)
        {
            Faculty = f;
            ID = GenerateId(year, speciality);
            if (ExistingGroupsCount.ContainsKey(new Tuple<int, string>(year, speciality)))
            {
                ExistingGroupsCount[new Tuple<int, string>(year, speciality)]++;
            }
            else
            {
                ExistingGroupsCount.Add(new Tuple<int, string>(year, speciality), 1);
            }
        }

        private static string GenerateId(int year, string speciality)
        {
            return string.Format("{0} {1}", year, speciality);
        }

        public void Add(Student s)
        {
            _students.Add(s);
        }
    }

}
