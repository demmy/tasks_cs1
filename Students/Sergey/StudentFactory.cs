using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Sergey
{
    class StudentFactory : IStudentFactory
    {
        Random _rnd = new Random();
        private readonly string[] _studentLastNames = {
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

        private DateTime RndDateOfBirth(DateTime startPoint, DateTime endPoint)
        {
            var date = startPoint;
            int daysRange = (endPoint - startPoint).Days;
            return date.AddDays(daysRange);
        }
        public IStudent CreateRandomStudent()
        {
            var rndFirstName = _studentFirstNames[_rnd.Next(_studentFirstNames.Length)];
            var rndLastName = _studentLastNames[_rnd.Next(_studentLastNames.Length)];

            var currentDate = DateTime.Now;
            var rndDateOfBirth = RndDateOfBirth(currentDate.AddYears(-150), currentDate.AddYears(-10));

            var newStudent = new Student(rndDateOfBirth, rndLastName, rndFirstName)
            {
                CurrentGroup = (Group)_rnd.Next(Enum.GetNames(typeof(Group)).Length)
            };

            var subjects = Enum.GetValues(typeof(Subject)).Cast<Subject>();
            int marksNumber = Enum.GetValues(typeof (Mark)).Length;
            foreach (var subject in subjects)
            {
                newStudent.SetMark(subject, (Mark)_rnd.Next(marksNumber));
            }
            return newStudent;
        }


        public IMarksCalculator MarksCalculator
        {
            get { throw new NotImplementedException(); }
        }


        public string ProgrammerName
        {
            get { return "Serge Matvienko"; }
        }
    }
}
