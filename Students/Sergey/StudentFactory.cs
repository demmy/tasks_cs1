using System;
using System.Collections.Generic;
using System.Linq;

namespace Students.Sergey
{
    class StudentFactory : IStudentFactory
    {
        #region PrivateFields

        private readonly Random _rnd = new Random();

        private readonly string[] _studentLastNames =
        {
            "Иванов",
            "Смирнов",
            "Кузнецов",
            "Попов",
            "Васильев",
            "Петров",
            "Соколов",
            "Михайлов",
            "Новиков",
            "Фёдоров",
            "Морозов",
            "Волков",
            "Алексеев",
            "Лебедев",
            "Семёнов",
            "Егоров",
            "Павлов",
            "Козлов",
            "Степанов",
            "Николаев",
            "Орлов",
            "Андреев",
            "Макаров",
            "Никитин",
            "Захаров"
        };

        private readonly string[] _studentFirstNames =
        {
            "Даниил",
            "Александр",
            "Никита",
            "Дмитрий",
            "Андрей",
            "Иван",
            "Михаил",
            "Сергей",
            "Никита",
            "Игорь",
            "Анастасия",
            "Мария",
            "Дарья",
            "Елизавета",
            "Александра",
            "Полина",
            "Анна",
            "Марина",
            "Татьяна",
            "Карина"
        };

        #endregion

        #region InnerClasses

        private sealed class StudentMarksCalculator : IMarksCalculator
        {

            public IReadOnlyDictionary<IStudent, double> AverageMarkPerStudent(IReadOnlyList<IStudent> students)
            {
                //Just get the average mark per student
                var averageMarks = students.ToDictionary(student => student,
                    student => student.GetAllMarks().Average(x => (int)x.Value));
                return averageMarks;
            }

            public IReadOnlyDictionary<Subject, double> AverageMarkPerSubject(IReadOnlyList<IStudent> students)
            {
                //Get all subjects, avoid multiple enumerators
                var subjects = Enum.GetValues(typeof(Subject)).Cast<Subject>();
                var subjs = subjects as IList<Subject> ?? subjects.ToList();
                //Create dictionary where will be put all average marks per subject
                var averageMarks = subjs.ToDictionary<Subject, Subject, double>(subject => subject, subject => 0f);
                //Sum of marks for each subject (now we see why LINQ is not the SQL like)
                foreach (var subj in students.SelectMany(student => student.GetAllMarks()))
                    averageMarks[subj.Key] += (int)subj.Value;
                //To calc average from Sum of marks per subject, now it works in case every student has got all subject
                //If we need more, we should create an array with number of students learning current subject
                foreach (var subj in subjs)
                    averageMarks[subj] /= students.Count;

                return averageMarks;
            }

            public IReadOnlyDictionary<Group, double> AverageMarkPerGroup(IReadOnlyList<IStudent> students)
            {
                //We get the (something) that is grouped by Group field and with (something like) Enumeration of average marks per Student
                var marksByGroup = from student in students
                                   group student.GetAllMarks().Values.Average(num => (int)num)
                                   by student.CurrentGroup;
                //Here we get Dictionary of Group and average mark per Group
                var averageMarks = marksByGroup.ToDictionary(group => group.Key,
                    aver => aver.Average(x => x));

                return averageMarks;
            }

            public IReadOnlyDictionary<Tuple<Group, Subject>, double> AverageMarkPerGroupPerSubject(IReadOnlyList<IStudent> students)
            {
                throw new NotImplementedException();
            }
        }
        #endregion

        #region Implementations

        private DateTime RndDateOfBirth(DateTime startPoint, DateTime endPoint)
        {
            var date = startPoint;
            int daysRange = (endPoint - startPoint).Days;
            return date.AddDays(_rnd.Next(daysRange));
        }

        public IStudent CreateRandomStudent()
        {
            var rndFirstName = _studentFirstNames[_rnd.Next(_studentFirstNames.Length)];
            var rndLastName = _studentLastNames[_rnd.Next(_studentLastNames.Length)];

            var currentDate = DateTime.Now;
            var rndDateOfBirth = RndDateOfBirth(currentDate.AddYears(-150), currentDate.AddYears(-10));

            var newStudent = new Student(rndDateOfBirth, rndLastName, rndFirstName)
            {
                CurrentGroup = (Group) _rnd.Next(Enum.GetNames(typeof (Group)).Length)
            };

            var subjects = Enum.GetValues(typeof (Subject)).Cast<Subject>();
            int marksNumber = Enum.GetValues(typeof (Mark)).Length;
            foreach (var subject in subjects)
            {
                newStudent.SetMark(subject, (Mark) _rnd.Next(marksNumber));
            }
            return newStudent;
        }


        public IMarksCalculator MarksCalculator
        {
            get { return new StudentMarksCalculator(); }
        }


        public string ProgrammerName
        {
            get { return "Serge Matvienko"; }
        }

        #endregion

    }
}
