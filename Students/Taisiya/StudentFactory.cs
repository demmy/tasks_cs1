using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Taisiya
{
    class StudentFactory : IStudentFactory
    {
        const string Programmer = "Taisiya Loza";

        string[] massFirstName = { "Ann", "Ben", "Cal", "Den", "Jack" };
        string[] massLastName = { "Johnson", "Brown", "Smith", "Lee", "Jackson" };
        string[] cityOfBirth = { "London", "Paris", "Berlin", "Madrid", "Oslo" };
        Random rand = new Random();
        string[] groups = Enum.GetNames(typeof(Group));
        Array marks = Enum.GetValues(typeof(Mark));

        public IStudent CreateRandomStudent()
        {
            Student student = new Student(massFirstName[rand.Next(massFirstName.Length)],
                massLastName[rand.Next(massLastName.Length)], 
                new DateOfBirth( rand.Next(1, 31), rand.Next(1,13), rand.Next(1960, 2015), cityOfBirth[rand.Next(cityOfBirth.Length)]),
                (Group)Enum.Parse(typeof(Group),groups[rand.Next(groups.Length)]));

            
            foreach (Subject s in Enum.GetValues(typeof(Subject)))
                student.SetMark(s, (Mark)marks.GetValue(rand.Next(marks.Length)));

            return student;
        }


        public IMarksCalculator MarksCalculator
        {
            get { return new Calculator(); }
        }


        public string ProgrammerName
        {
            get { return Programmer; }
        }


        private sealed class Calculator : IMarksCalculator
        {

            public IReadOnlyDictionary<IStudent, double> AverageMarkPerStudent(IReadOnlyList<IStudent> students)
            {
                double sum = 0;
                double k = 0;
                Dictionary<IStudent, double> AverageMark = new Dictionary<IStudent, double>();

                foreach (var s in students)
                {
                    foreach (var a in s.GetAllMarks().Values)
                    {
                        sum += Convert.ToDouble(a);
                        k++;
                    }
                    AverageMark[s] = sum / k;
                }
                return AverageMark;
            }

            public IReadOnlyDictionary<Subject, double> AverageMarkPerSubject(IReadOnlyList<IStudent> students)
            {
                double sum = 0;
                double k = 0;
                Dictionary<Subject, double> AverageMark = new Dictionary<Subject, double>();
                List<double> allMarks = new List<double>();

                foreach (Subject subj in Enum.GetValues(typeof(Subject)))
                {
                    foreach (var s in students)
                    {
                        allMarks.Add(Convert.ToDouble(s.GetMark(subj)));

                        foreach (var a in allMarks)
                        {
                            sum += a;
                            k++;
                        }
                    }
                    AverageMark[subj] = sum / k;
                }

                return AverageMark;
            }

            public IReadOnlyDictionary<Group, double> AverageMarkPerGroup(IReadOnlyList<IStudent> students)
            {
                double sum = 0;
                double k = 0;
                Dictionary<Group, double> AverageMark = new Dictionary<Group, double>();

                foreach (Group gr in Enum.GetValues(typeof(Group)))
                {
                    foreach (var s in students)
                        if (s.CurrentGroup == gr)
                        {
                            foreach (var a in AverageMarkPerStudent(students).Values)
                            {
                                sum += Convert.ToDouble(a);
                                k++;
                            }
                        }                 
                    AverageMark[gr] = sum / k;
                }

                return AverageMark;
            }

            public IReadOnlyDictionary<Tuple<Group, Subject>, double> AverageMarkPerGroupPerSubject(IReadOnlyList<IStudent> students)
            {
                Dictionary<Tuple<Group, Subject>, double> AverageMark = new Dictionary<Tuple<Group, Subject>, double>();
                List<IStudent> group = new List<IStudent>();

                foreach (Group gr in Enum.GetValues(typeof(Group)))
                {
                    foreach (var s in students)
                        if (s.CurrentGroup == gr)
                            group.Add(s);

                        foreach (var a in AverageMarkPerSubject(group))
                            AverageMark.Add(Tuple.Create<Group, Subject>(gr, a.Key), Convert.ToDouble(a.Value)); 
                }
                      
                return AverageMark;
            }
        }
    }
}
