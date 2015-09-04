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
            List<Room> rooms = new List<Room>();
            List<Teacher> teachers = new List<Teacher>();
            List<Student> students = new List<Student>();
            List<Group> groups = new List<Group>();
            Schedule schedule= new Schedule();
            return new University(title, groups, teachers, rooms, schedule);
           

        }

        public string ProgrammerName
        {
            get { return "Tatyana"; }
        }

        private Student CreateRandomStudent()
        {
            indexOfUniqueStudent++;
            string firstName1 = "Student" + indexOfUniqueStudent.ToString();
            string middleName1 = "M" + r.Next(1, 1000).ToString();
            string lastName1 = "N" + r.Next(1, 1000).ToString();
            DateTime dateOfBirth1 = (new DateTime(1950, 1, 1)).AddDays(r.Next(20000));
            return new Student(firstName1, middleName1, lastName1, dateOfBirth1);
        }


        private Teacher CreateRandomTeacher()
        {
            indexOfUniqueTeacher++;
            PositionType p = (PositionType)r.Next(1, 4);
            string firstName1 = p.ToString() + indexOfUniqueStudent.ToString();
            string middleName1 = "M" + r.Next(1, 1000).ToString();
            string lastName1 = "N" + r.Next(1, 1000).ToString();
            DateTime dateOfBirth1 = (new DateTime(1950, 1, 1)).AddDays(r.Next(20000));
            return new Teacher(firstName1, middleName1, lastName1, dateOfBirth1,p);
        }

        private List<Student> CreateListStudents(int length)
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < length; i++)
            {
                students.Add(CreateRandomStudent());
            }
            return students;
        }

        private List<Teacher> CreateListTeacher(int length)
        {
            List<Teacher> teachers = new List<Teacher>();
            for (int i = 0; i < length; i++)
            {
                teachers.Add(CreateRandomTeacher());
            }
            return teachers;
        }

        private List<Room> CreateListRooms(int length, int countBuilding)
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

        private List<Group> CreateListGroupsWithStudents(int countGroup, int maxCountStudents,
          int countFaculty, int countSpesiality)
        {
            List<Group> groups = new List<Group>();
            int countStudents;
            for (int i = 0; i < countGroup; i++)
            {
                groups.Add(new Group((FacultyType)r.Next(1, countFaculty + 1),
                                      r.Next(2000 - 2008),
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
