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
            //list<room> rooms = new list<room>();
            //list<teacher> teachers = new list<teacher>();
            //list<student> students = new list<student>();
            //list<group> groups = new list<group>();
            List<Room> rooms = CreateListRooms(r.Next(10,20),4);
            List<Teacher> teachers =CreateListTeacher(r.Next(10,15));
             
            List<Group> groups = CreateListGroupsWithStudents(3,5,1,2);
            Schedule schedule= new Schedule();
            return new University(title, groups, teachers, rooms);
           

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
            PositionType p = (PositionType)r.Next(1, 4);
            string firstName1 = p.ToString() + indexOfUniqueTeacher.ToString();
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
