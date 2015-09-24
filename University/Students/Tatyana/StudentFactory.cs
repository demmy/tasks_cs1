using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Tatyana
{
    class StudentFactory : IStudentFactory
    {

        Random r = new Random();
        static int indexOfUniqueStudent = 0;
        public IStudent CreateRandomStudent()
        {

            indexOfUniqueStudent++;
            string firstName1 = "Student" + indexOfUniqueStudent.ToString();
            string lastName1 = "N" + r.Next(1, 1000).ToString();
            DateTime dateOfBirth1 = (new DateTime(1950, 1, 1)).AddDays(r.Next(20000));
            Group group = (Group)r.Next(2);
            Dictionary<Subject, Mark> marks1 = new Dictionary<Subject, Mark>();
            for (int i = 0; i < 5; i++)
            {
                marks1[(Subject)i] = (Mark)r.Next(1, 6);
            }
            return new Student(firstName1, lastName1, dateOfBirth1, group, marks1);

        }


        public IMarksCalculator MarksCalculator
        {
            get { return new CalculatorAverageMarks(); }
        }

        public string ProgrammerName
        {
            get { return "Tat'yana"; }
        }


        class CalculatorAverageMarks : IMarksCalculator
        {
            public IReadOnlyDictionary<IStudent, double> AverageMarkPerStudent(IReadOnlyList<IStudent> students)
            {
                Dictionary<IStudent, double> averageMarkStudents = new Dictionary<IStudent, double>();
                foreach (IStudent student in students)
                {
                    double s = 0;
                    foreach (Mark m in student.GetAllMarks().Values)
                    {
                        s += (int)m;
                    }
                    averageMarkStudents[student] = s / student.GetAllMarks().Count;
                }
                return averageMarkStudents;
            }

            public IReadOnlyDictionary<Subject, double> AverageMarkPerSubject(IReadOnlyList<IStudent> students)
            {
                Dictionary<Subject, double> averageMarksSubject = new Dictionary<Subject, double>();
                Dictionary<Subject, double> sumMarksSubject = new Dictionary<Subject, double>();
                Dictionary<Subject, int> countStudentForSubject = new Dictionary<Subject, int>();

                foreach (IStudent s in students)
                {
                    foreach (var subjectMark in s.GetAllMarks())
                    {
                        if (!countStudentForSubject.ContainsKey(subjectMark.Key))
                        {
                            countStudentForSubject.Add(subjectMark.Key, 0);
                            sumMarksSubject.Add(subjectMark.Key, 0);
                        }

                        sumMarksSubject[subjectMark.Key] += (int)subjectMark.Value;
                        countStudentForSubject[subjectMark.Key]++;
                    }
                }


                foreach (Subject s1 in sumMarksSubject.Keys)
                {
                    averageMarksSubject[s1] = sumMarksSubject[s1] /
                                        countStudentForSubject[s1];
                }
                return averageMarksSubject;

            }

            public IReadOnlyDictionary<Group, double> AverageMarkPerGroup(IReadOnlyList<IStudent> students)
            {
                Dictionary<Group, double> averageMarkGroup = new Dictionary<Group, double>();
                Dictionary<Group, double> sumMarksGroup = new Dictionary<Group, double>();
                Dictionary<Group, int> countStudentForGroup = new Dictionary<Group, int>();

                foreach (IStudent s in students)
                {
                    if (!countStudentForGroup.ContainsKey(s.CurrentGroup))
                    {
                        countStudentForGroup.Add(s.CurrentGroup, 0);
                        sumMarksGroup.Add(s.CurrentGroup, 0);
                    }
                    foreach (var subjectMark in s.GetAllMarks())
                    {
                        sumMarksGroup[s.CurrentGroup] += (int)subjectMark.Value;
                        countStudentForGroup[s.CurrentGroup]++;
                    }
                }


                foreach (Group s1 in sumMarksGroup.Keys)
                {
                    averageMarkGroup[s1] = sumMarksGroup[s1] /
                                        countStudentForGroup[s1];
                }
                return averageMarkGroup;
            }

            public IReadOnlyDictionary<Tuple<Group, Subject>, double> AverageMarkPerGroupPerSubject(IReadOnlyList<IStudent> students)
            {
                Dictionary<Tuple<Group, Subject>, double> averageMarkGroupSubject =
                                                     new Dictionary<Tuple<Group, Subject>, double>();

                Dictionary<Tuple<Group, Subject>, double> sumMarkGroupSubject =
                                                     new Dictionary<Tuple<Group, Subject>, double>();
                Dictionary<Tuple<Group, Subject>, int> countMarkGroupSubject =
                                                     new Dictionary<Tuple<Group, Subject>, int>();
                Tuple<Group, Subject> t;

                foreach (IStudent s in students)
                {
                    foreach (var subjectMark in s.GetAllMarks())
                    {

                        t = new Tuple<Group, Subject>(s.CurrentGroup, subjectMark.Key);

                        if (!countMarkGroupSubject.ContainsKey(t))
                        {
                            countMarkGroupSubject.Add(t, 0);
                            sumMarkGroupSubject.Add(t, 0);
                        }

                        sumMarkGroupSubject[t] += (int)subjectMark.Value;
                        countMarkGroupSubject[t]++;
                    }
                }


                foreach (var s1 in sumMarkGroupSubject.Keys)
                {
                    averageMarkGroupSubject[s1] = sumMarkGroupSubject[s1] /
                                        countMarkGroupSubject[s1];
                }
                return averageMarkGroupSubject;

            }
        }
        
    }
}
