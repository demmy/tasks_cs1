using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace University.Sergey.Models
{
    class Group : IReadOnlyGroup, IList<Student>
    {
        private readonly IList<Student> _students;
        //The field to control number of existing groups of each faculty and speciality
        private static readonly IDictionary<Tuple<string, string>, int> ExistingGroupsOnSpecialityNumber;

        static Group()
        {
            ExistingGroupsOnSpecialityNumber = 
                (from relation in University.FacultyToSpecialityRelations
                    from speciality in relation.Value
                        select new Tuple<string, string>(relation.Key, speciality))
                            .ToDictionary(key => key, value => 0);
            //and here is possible to fill 0-s with explicit numbers if we got the file or db where to load from
        }

        public Group(string faculty, string speciality, int year)
        {
            if (!University.FacultyToSpecialityRelations.ContainsKey(faculty))
            {
                if (!University.FacultyToSpecialityRelations[faculty].Contains(speciality))
                {
                    throw new ArgumentException("There is no such speciality on this faculty");
                }
            }
            Faculty = (FacultyType)Enum.Parse(typeof (FacultyType), faculty);
            _students = new List<Student>();
            ID = NewId(faculty, speciality, year);
        }

        private static string NewId(string faculty, string speciality, int year)
        {
            return string.Format("{0}-{1}-{2}", speciality, year,
                ++ExistingGroupsOnSpecialityNumber[new Tuple<string, string>(faculty, speciality)]);
        }

        #region Properties

        public string ID { get; private set; }
        public FacultyType Faculty { get; private set; }

        public IEnumerable<IReadOnlyPerson> Students
        {
            get { return _students; }
        }

        #endregion

        #region IList

        public IEnumerator<Student> GetEnumerator()
        {
            return _students.Select(student => student).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Student item)
        {
            _students.Add(item);
        }

        public void Clear()
        {
            _students.Clear();
        }

        public bool Contains(Student item)
        {
            return _students.Contains(item);
        }

        public void CopyTo(Student[] array, int arrayIndex)
        {
            array.CopyTo(_students.ToArray(), arrayIndex);
        }

        public bool Remove(Student item)
        {
            return _students.Remove(item);
        }

        public int Count
        {
            get { return _students.Count; }
        }

        public bool IsReadOnly {
            get { return true; }
        }
        
        public int IndexOf(Student item)
        {
            return _students.IndexOf(item);
        }

        public void Insert(int index, Student item)
        {
            _students.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _students.RemoveAt(index);
        }

        public Student this[int index]
        {
            get { return _students[index]; }
            set { _students[index] = value; }
        }
        #endregion
    }
}
