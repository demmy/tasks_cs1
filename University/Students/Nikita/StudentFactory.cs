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
            return new Student(ListOfNames[rndIndex].Key, ListOfNames[rndIndex].Value, (Mark) _rnd.Next(2,5),
                (Group) _rnd.Next(2), new Dictionary<Subject, Mark>()
                {
                    {Subject.English, (Mark) _rnd.Next(2,5)},
                    {Subject.History, (Mark) _rnd.Next(2,5)},
                    {Subject.Math, (Mark) _rnd.Next(2,5)},
                    {Subject.Physics, (Mark) _rnd.Next(2,5)},
                    {Subject.Programming, (Mark) _rnd.Next(2,5)}
                },
                new DateTime(_rnd.Next(1990, DateTime.Now.Year), _rnd.Next(1, 11), _rnd.Next(1, 30)));
        }


        public IMarksCalculator MarksCalculator
        {
            get { return new MarksCalculate(); }
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
                Dictionary<Subject, Tuple<double, int>> averageMarksAndCounters =
                    new Dictionary<Subject, Tuple<double, int>>();
                foreach (var student in students)
                {
                    foreach (var subjectAndMark in student.GetAllMarks())
                    {
                        if (!averageMarksAndCounters.ContainsKey(subjectAndMark.Key))
                        {
                            averageMarksAndCounters.Add(subjectAndMark.Key,
                                new Tuple<double, int>((Int32) subjectAndMark.Value, 1));
                        }
                        else
                        {
                            averageMarksAndCounters[subjectAndMark.Key] =
                                new Tuple<double, int>(
                                    averageMarksAndCounters[subjectAndMark.Key].Item1 + (Int32) subjectAndMark.Value,
                                    averageMarksAndCounters[subjectAndMark.Key].Item2 + 1);
                        }
                    }
                }
                return averageMarksAndCounters.ToDictionary(markAndCounter => markAndCounter.Key, markAndCounter => markAndCounter.Value.Item1/markAndCounter.Value.Item2);
            }


            public IReadOnlyDictionary<Group, double> AverageMarkPerGroup(IReadOnlyList<IStudent> students)
            {
                Dictionary<Group, double> averageMarks = new Dictionary<Group, double>();

                foreach (var group in Enum.GetValues(typeof (Group)))
                {
                    foreach (var student in students)
                    {
                        int marksCounter = 0;
                        double averageMark = 0;
                        if (student.CurrentGroup == (Group) group)
                        {
                            foreach (var kvp in student.GetAllMarks())
                            {
                                averageMark += (Int32) kvp.Value;
                                marksCounter++;
                            }
                            if (!averageMarks.ContainsKey(student.CurrentGroup))
                            {
                                averageMarks.Add(student.CurrentGroup, averageMark/marksCounter);
                            }
                            else
                            {
                                averageMarks[student.CurrentGroup] = ((averageMarks[student.CurrentGroup] +
                                                                       averageMark/marksCounter)/2);
                            }
                        }
                    }
                }
                return averageMarks;
            }

            public IReadOnlyDictionary<Tuple<Group, Subject>, double> AverageMarkPerGroupPerSubject(IReadOnlyList<IStudent> students)
            {
                Dictionary<Tuple<Group, Subject>, double> averageMarks = new Dictionary<Tuple<Group, Subject>, double>();

                foreach (var group in Enum.GetValues(typeof(Group)))
                {
                    foreach (var student in students)
                    {
                        if (student.CurrentGroup == (Group)group)
                        {
                            foreach (var kvp in student.GetAllMarks())
                            {
                                if (!averageMarks.ContainsKey(new Tuple<Group, Subject>(student.CurrentGroup, kvp.Key)))
                                {
                                    averageMarks.Add(new Tuple<Group, Subject>(student.CurrentGroup, kvp.Key), (Int32)kvp.Value);
                                }
                                else
                                {
                                    averageMarks[new Tuple<Group, Subject>(student.CurrentGroup, kvp.Key)] = ((averageMarks[new Tuple<Group, Subject>(student.CurrentGroup, kvp.Key)] +
                                                                           (Int32)kvp.Value) / 2);
                                }
                            }
                            
                        }
                    }
                }
                return averageMarks;
            }
        }
    }
}
