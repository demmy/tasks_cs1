using System;
using System.Collections.Generic;
using System.Linq;

namespace Students.Sergey
{
    class StudentFactory : IStudentFactory
    {
        #region PrivateFields
        //Randomizer
        private readonly Random _rnd = new Random();
        //Array of Students Last Names (now hardcoded)
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
        //Array of students First Names (now hardcoded)
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
        /// <summary>
        /// Calculator class that gives a possibility for Factory to calc diffefent Averages
        /// </summary>
        private sealed class StudentMarksCalculator : IMarksCalculator
        {
            /// <summary>
            /// The function to calculate the average grade for each of students
            /// </summary>
            /// <param name="students">Receives the collection of students with their marks</param>
            /// <returns>the dictionary of students with related average mark</returns>
            public IReadOnlyDictionary<IStudent, double> AverageMarkPerStudent(IReadOnlyList<IStudent> students)
            {
                //Just get the average mark per student
                var averageMarks = students.ToDictionary(student => student,
                    student => student.GetAllMarks().Average(mark => (int)mark.Value));
                return averageMarks;
            }
            /// <summary>
            /// The function to calculate the average grade for each subject that students are studying
            /// </summary>
            /// <param name="students">Receives the collection of students with their marks</param>
            /// <returns>The dictionary of subject with it's related average mark, got from every student studying thi subject</returns>
            public IReadOnlyDictionary<Subject, double> AverageMarkPerSubject(IReadOnlyList<IStudent> students)
            {
                //Get (something like) Enumeration of Dictionaries of Subject+Mark
                var allMarks = from student in students
                               select student.GetAllMarks();

                //Get something of grouped by Subject marks 
                var sub = from mark in allMarks
                          from pair in mark
                          group pair.Value by pair.Key
                              into result
                              orderby result.Key
                              select result;

                //Get the Dictionary of Subject and Average Mark
                var averageMarks = sub.ToDictionary(subject => subject.Key, marks => marks.Average(mark => (int)mark));

                return averageMarks;
            }
            /// <summary>
            /// The function to calculate the average grade for each group of students
            /// </summary>
            /// <param name="students">Receives the collection of students with their marks</param>
            /// <returns>The dictionary of Group and related average grade</returns>
            public IReadOnlyDictionary<Group, double> AverageMarkPerGroup(IReadOnlyList<IStudent> students)
            {
                //We get the (something) that is grouped by Group field and with (something like) Enumeration of average marks per Student
                var marksByGroup = from student in students
                                   group student.GetAllMarks().Values.Average(num => (int)num)
                                   by student.CurrentGroup
                                   into result
                                   orderby result.Key
                                   select result;

                //Here we get Dictionary of Group and average mark per Group
                var averageMarks = marksByGroup.ToDictionary(group => group.Key,
                    aver => aver.Average(x => x));

                return averageMarks;
            }
            /// <summary>
            /// The function to calculate the average grade for every subject (moreover, now for each group)
            /// </summary>
            /// <param name="students">Receives the collection of students with their marks</param>
            /// <returns>the dictionary of pair Group-Subject with average grade for ecah of them</returns>
            public IReadOnlyDictionary<Tuple<Group, Subject>, double> AverageMarkPerGroupPerSubject(IReadOnlyList<IStudent> students)
            {
                //Get the IEnumerable of Dictionaries of Subject and Mark grouped by Group of Student
                var marksByGroup = from student in students
                                   group student.GetAllMarks()
                                   by student.CurrentGroup;
                //Now transform it in the way to get the IEnumerable of Pair Group-Subject with collection of related Marks
                var drub = from grMarks in marksByGroup
                           from marks in grMarks
                           from mark in marks
                           group mark.Value by new Tuple<Group, Subject>(grMarks.Key, mark.Key)
                           into result
                           orderby result.Key
                           select result;
                //Convert to dictionary of Tuple Group-Subject with value of average marks from collection got from previous step
                var averageMarks = drub.ToDictionary(groupSubjPair => groupSubjPair.Key,
                    marks => marks.Average(mark => (int)mark));

                return averageMarks;
            }
        }
        #endregion

        #region Implementations
        /// <summary>
        /// Function to create new date of Birth from the interval of possible years
        /// </summary>
        /// <param name="startPoint">The start point of years interval for student (the oldest student case)</param>
        /// <param name="endPoint">The end point of years interval for student (the youngest student case)</param>
        /// <returns>New day of Birth</returns>
        private DateTime RndDateOfBirth(DateTime startPoint, DateTime endPoint)
        {
            var date = startPoint;
            int daysRange = (endPoint - startPoint).Days;
            return date.AddDays(_rnd.Next(daysRange));
        }
        /// <summary>
        /// Function to create absolutely random student
        /// </summary>
        /// <returns>New Student</returns>
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

        /// <summary>
        /// Returns current calculator "machine"
        /// </summary>
        public IMarksCalculator MarksCalculator
        {
            get { return new StudentMarksCalculator(); }
        }

        /// <summary>
        /// return the name of His Master :)
        /// </summary>
        public string ProgrammerName
        {
            get { return "Serge Matvienko"; }
        }

        #endregion
    }
}
