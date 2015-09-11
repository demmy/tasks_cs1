using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Tatyana
{
    class UniversityFactory : IUniversityFactory
    {
        Random r = new Random();
        static int indexOfUniqueStudent;
        static int indexOfUniqueTeacher;
        
         

        public IUniversity CreateUniversity(string title)
        {
            List<Room> rooms = CreateListRooms(r.Next(10,20),4);
            List<Teacher> teachers =CreateListTeacher(r.Next(10,15));
             
            List<Group> groups = CreateListGroupsWithStudents(3,5,1,2);

            University u1 = new University(title, groups, teachers, rooms);

            DateTime date1 = new DateTime(2015, 9, 10);
            List<Teacher> teachers1=new List<Teacher>();
            teachers1.Add(teachers.ElementAt<Teacher>(0));
            teachers1.Add(teachers.ElementAt<Teacher>(2));
            List<Teacher> teachers2 = new List<Teacher>();
            teachers2.Add(teachers.ElementAt<Teacher>(1));
            List<Group> groups1=new List<Group>();
            groups1.Add(groups.ElementAt<Group>(0)); 
            groups1.Add(groups.ElementAt<Group>(1));
            List<Group> groups2=new List<Group>();
            groups2.Add(groups.ElementAt<Group>
                (0));
            u1.AddLesson(DateTime.Now, LessonsOrder.EighthLesson, rooms.ElementAt<Room>(1), teachers, groups);

            u1.AddLesson(date1, LessonsOrder.FirstLesson, rooms.ElementAt<Room>(1), teachers1, groups1);
            u1.AddLesson(date1, LessonsOrder.SecondLesson, rooms.ElementAt<Room>(0), teachers1, groups1);
            u1.AddLesson(date1, LessonsOrder.ThirdLesson, rooms.ElementAt<Room>(1), teachers1, groups2);
            u1.AddLesson(date1, LessonsOrder.FirstLesson, rooms.ElementAt<Room>(2), teachers1, groups2);
            u1.AddLesson(date1, LessonsOrder.FirstLesson, rooms.ElementAt<Room>(0), teachers1, groups1);
            return u1;

        }

        public string ProgrammerName
        {
            get { return "Tatyana"; }
        }

        


       public Student CreateRandomStudent()
        {
            indexOfUniqueStudent++;
            string firstName1 = "Student" + indexOfUniqueStudent.ToString();
            string middleName1 = "M" + r.Next(1, 1000).ToString();
            string lastName1 = "N" + r.Next(1, 1000).ToString();
            DateTime dateOfBirth1 = (new DateTime(1950, 1, 1)).AddDays(r.Next(20000));
            return new Student(firstName1, middleName1, lastName1, dateOfBirth1);
        }


        public Teacher CreateRandomTeacher()
        {
            indexOfUniqueTeacher++;
            PositionType p = (PositionType)r.Next((int)PositionType.AfterLastPosition );
            string firstName1 = p.ToString() + indexOfUniqueTeacher.ToString();
            string middleName1 = "M" + r.Next(1, 1000).ToString();
            string lastName1 = "N" + r.Next(1, 1000).ToString();
            DateTime dateOfBirth1 = (new DateTime(1950, 1, 1)).AddDays(r.Next(20000));
            return new Teacher(firstName1, middleName1, lastName1, dateOfBirth1,p);
        }

        public List<Student> CreateListStudents(int length)
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < length; i++)
            {
                students.Add(CreateRandomStudent());
            }
            return students;
        }

        public List<Teacher> CreateListTeacher(int length)
        {
            List<Teacher> teachers = new List<Teacher>();
            for (int i = 0; i < length; i++)
            {
                teachers.Add(CreateRandomTeacher());
            }
            return teachers;
        }

        public List<Room> CreateListRooms(int length, int countBuilding)
        {
            List<Room> rooms = new List<Room>();
            Dictionary<Building,int> count=new Dictionary<Building,int>();
            Building building=(Building) 1;
            for (int i = 0; i < length; i++)
            {
                building = (Building) r.Next(1, countBuilding);
                if (!count.ContainsKey(building)) 
                {
                    count[building]=0;
                }
                count[building]+=1;
                rooms.Add(new Room(building, count[building]));
            }
            return rooms;
        }

        private List<Group> CreateListGroups(int countGroup, int countAllStudents,
                  int countFaculty, int countSpesiality)
        {
            List<Group> groups = new List<Group>();
            Group group;
            for (int i = 0; i < countGroup; i++)
            {
                groups.Add(new Group((FacultyType) r.Next(1,countFaculty+1),
                                      r.Next(2000-2008), 
                           string.Format("{0}", (SpecialityTitle) r.Next(1,countSpesiality+1))));
            }
            for (int i = 0; i < countAllStudents; i++)
            {
                groups[r.Next(0, groups.Count)].Add(CreateRandomStudent());
            }
            
                return groups;
        }

        public List<Group> CreateListGroupsWithStudents(int countGroup, int maxCountStudents,
          int countFaculty, int countSpesiality)
        {
            List<Group> groups = new List<Group>();
            int countStudents;
            for (int i = 0; i < countGroup; i++)
            {
                groups.Add(new Group((FacultyType)r.Next(1, countFaculty + 1),
                                      r.Next(2000, 2008),
                           string.Format("{0}", (SpecialityTitle)r.Next(1, countSpesiality + 1))));
            }
            foreach (Group group in groups)
            {
                countStudents = r.Next(1, maxCountStudents + 1);
                for (int i = 0; i < countStudents; i++)
                {
                           
                    group.Add(new Student(group.ID+"-" + (i+1) ,
                        "M" + r.Next(1, 1000).ToString() ,
                        "N" + r.Next(1, 1000).ToString() ,
                        (new DateTime(1950, 1, 1)).AddDays(r.Next(20000))));
                }
            }
            return groups;
        }
                 
        
    }
}
