using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Nikita
{
    class StudentFactory : IStudentFactory
    {
        Random _rnd = new Random();
        private static List<KeyValuePair<string, string>> ListOfNames = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string, string>("Carl", "Henry"),
            new KeyValuePair<string, string>("Evgen", "Ivan"),
            new KeyValuePair<string, string>("Ryehn", "Pokeyt"),
            new KeyValuePair<string, string>("Caue", "Lount"),
            new KeyValuePair<string, string>("Riky", "Martin"),
            new KeyValuePair<string, string>("Webs", "Kollins"),
            new KeyValuePair<string, string>("Bomj", "Icarus"),
            new KeyValuePair<string, string>("Wevc", "Tync"),
            new KeyValuePair<string, string>("Qwe", "Lko"),
            new KeyValuePair<string, string>("Sad", "Man"),

        };

        public IStudent CreateRandomStudent()
        {
            int rndIndex = _rnd.Next(ListOfNames.Count);
            return new Student(ListOfNames[rndIndex].Key, ListOfNames[rndIndex].Value, (Mark) _rnd.Next(5),
                (Group) _rnd.Next(2), new Dictionary<Subject, Mark>(),
                new DateTime(_rnd.Next(1950, DateTime.Now.Year), _rnd.Next(12), _rnd.Next(31)));
        }


        public IMarksCalculator MarksCalculator
        {
            get { throw new NotImplementedException(); }
        }


        public string ProgrammerName
        {
            get { return "Neekeeta"; }
        }

        class MarksCalculate : IMarksCalculator
        {
            public IReadOnlyDictionary<IStudent, double> AverageMarkPerStudent(IReadOnlyList<IStudent> students)
            {
                Dictionary<IStudent, double> averageMarksDict = new Dictionary<IStudent, double>();
                foreach (var student in students)
                {
                    double averageMark = 0;
                    
                    foreach (var kvp in student.GetAllMarks())
                    {
                        averageMark += (Int32) kvp.Value;
                    }
                    averageMarksDict.Add(student, averageMark/student.GetAllMarks().Count);
                }
                return averageMarksDict;
            }

            public IReadOnlyDictionary<Subject, double> AverageMarkPerSubject(IReadOnlyList<IStudent> students)
            {
                foreach (var student in students)
                {
                    
                }
               
            }

            public IReadOnlyDictionary<Group, double> AverageMarkPerGroup(IReadOnlyList<IStudent> students)
            {
                throw new NotImplementedException();
            }

            public IReadOnlyDictionary<Tuple<Group, Subject>, double> AverageMarkPerGroupPerSubject(IReadOnlyList<IStudent> students)
            {
                throw new NotImplementedException();
            }
        }
    }
}
