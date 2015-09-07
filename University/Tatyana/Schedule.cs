using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Tatyana
{


    class Schedule : ISchedule
    {
        class ScheduleItem
        {
            public LessonsOrder Lesson { get; set; }
            public Room Room { get; set; }
            public IEnumerable<Teacher> Teachsrs { get; set; }
            public IEnumerable<Group> Groups { get; set; }
        }
        Dictionary<DateTime, List<ScheduleItem>> items;
        TimeSpan[] timeOfStart = new TimeSpan[9] { new TimeSpan(6, 30, 0), new TimeSpan(8,0,0),
               new TimeSpan(9,30,0), new TimeSpan(11,10,0), new TimeSpan(12,30,0),
               new TimeSpan(14,10,0), new TimeSpan(15,40,0), new TimeSpan(16,10,0) ,
                new TimeSpan(17,30,0) };

        public Schedule()
        {
        }

        //public Schedule(Dictionary<DateTime, List<ScheduleItem>> items1)
        //{
        //    items = items1;
        //}

        private TimeSpan TimeOfStart(LessonsOrder lesson)
        {
            return timeOfStart[(int)lesson];
        }



        public IReadOnlyDictionary<string, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>> GetByDay(DateTime day)
        {
            Dictionary<string, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>> a =
                new Dictionary<string, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>();
            if (items.ContainsKey(day))
            {
                foreach (ScheduleItem s in items[day])
                {
                    if (!a.ContainsKey(s.Room.Id))
                    {
                        a[s.Room.Id] = new List<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>();
                    }
                    TimeSpan t = TimeOfStart(s.Lesson);
                    DateTime date = new DateTime(day.Year, day.Month, day.Day, t.Hours, t.Minutes, t.Seconds);
                    List<string> group = new List<string>();
                    List<string> teacher = new List<string>();
                    foreach (Teacher t1 in s.Teachsrs)
                    {
                        teacher.Add(t1.FullName);
                    }
                    foreach (Group g in s.Groups)
                    {
                        group.Add(g.ID);
                    }

                    Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>> timeTeacherGroups =
                        new Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>(date, teacher, group);
                    
                        

                }
            }
            return a;
        }

        public IReadOnlyDictionary<DateTime, IReadOnlyDictionary<string, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>> GetAll()
        {
            Dictionary<DateTime, IReadOnlyDictionary<string, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>> a=
                new Dictionary<DateTime,IReadOnlyDictionary<string,IReadOnlyList<Tuple<DateTime,IReadOnlyList<string>,IReadOnlyList<string>>>>>();
            foreach (DateTime d in items.Keys )
            {
                a[d] = new Dictionary<string, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>();
               foreach (ScheduleItem s in items[d])
                {
                    //if (!a[d].ContainsKey(s.Room.Id))
                    //{
                    //    a[d][s.Room.Id]= new List<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>();
                    //}
                    TimeSpan t = TimeOfStart(s.Lesson);
                    DateTime date = new DateTime(d.Year, d.Month, d.Day, t.Hours, t.Minutes, t.Seconds);
                    List<string> group = new List<string>();
                    List<string> teacher = new List<string>();
                    foreach (Teacher t1 in s.Teachsrs)
                    {
                        teacher.Add(t1.FullName);
                    }
                    foreach (Group g in s.Groups)
                    {
                        group.Add(g.ID);
                    }

                    Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>> timeTeacherGroups =
                        new Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>(date, teacher, group);
                   
                       

                
            }
            }
            return a;
        }

        public IReadOnlyDictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>> GetByRoom(string roomName)
        {
            Dictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>> a =
                new Dictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>>();
            foreach (DateTime d in items.Keys)
            {
                foreach (ScheduleItem s in items[d])
                {
                    if (object.Equals(s.Room.Id, roomName ))
                    {
                        if (!a.ContainsKey(d))
                        {
                            a[d]= new List<Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>>();
                        }
                        TimeSpan t = TimeOfStart(s.Lesson);
                        DateTime date = new DateTime(d.Year, d.Month, d.Day, t.Hours, t.Minutes, t.Seconds);
                        List<string> group = new List<string>();
                        List<string> teacher = new List<string>();
                        foreach (Teacher t1 in s.Teachsrs)
                            {
                              teacher.Add(t1.FullName);
                              }
                               foreach (Group g in s.Groups)
                            {
                                group.Add(g.ID);
                            }


                    Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>> timeTeacherGroups =
                        new Tuple<DateTime, IReadOnlyList<string>, IReadOnlyList<string>>(date, teacher, group);
                        
                    }
                }
            }

            return a;
        }

        public IReadOnlyDictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, bool>>> GetByGroup(string groupName)
        {
            Dictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, bool>>> a =
                  new Dictionary<DateTime, IReadOnlyList<Tuple<DateTime, IReadOnlyList<string>, bool>>>();
            foreach (DateTime d in items.Keys)
            {
                foreach (ScheduleItem s in items[d])
                {
                    foreach (Group g in s.Groups )
                    {
                        if (object.Equals(g.ID, groupName))
                        {
                            if (!a.ContainsKey(d))
                            {
                                a[d] = new List<Tuple<DateTime, IReadOnlyList<string>, bool>>();
                            }
                            TimeSpan t = TimeOfStart(s.Lesson);
                            DateTime date = new DateTime(d.Year, d.Month, d.Day, t.Hours, t.Minutes, t.Seconds);
                            List<string> group = new List<string>();
                            List<string> teacher = new List<string>();
                            foreach (Teacher t1 in s.Teachsrs)
                            {
                                teacher.Add(t1.FullName);
                            }
                            foreach (Group g1 in s.Groups)
                            {
                                group.Add(g1.ID);
                            }
                            bool b = (group.Count > 1) ? true : false;

                            Tuple<DateTime, IReadOnlyList<string>, bool> timeTeacherGroups =
                                new Tuple<DateTime, IReadOnlyList<string>, bool>(date, teacher, b);
                                
                        }
                    }
                }
            }

            return a;
            
        }

        public IReadOnlyDictionary<DateTime, IReadOnlyList<Tuple<DateTime, string, IReadOnlyList<string>>>> GetByTeacher(string teacherName)
        {
            Dictionary<DateTime, IReadOnlyList<Tuple<DateTime, string, IReadOnlyList<string>>>> a =
                 new Dictionary<DateTime, IReadOnlyList<Tuple<DateTime, string, IReadOnlyList<string>>>>();
            foreach (DateTime d in items.Keys)
            {
                foreach (ScheduleItem s in items[d])
                {
                    foreach (Teacher teacher in s.Teachsrs)
                    {
                        
                            if (object.Equals(teacher.FullName, teacherName))
                            {
                                if (!a.ContainsKey(d))
                                {
                                    a[d] = new List<Tuple<DateTime, string, IReadOnlyList<string>>>();
                                }
                                TimeSpan t = TimeOfStart(s.Lesson);
                                DateTime date = new DateTime(d.Year, d.Month, d.Day, t.Hours, t.Minutes, t.Seconds);
                                string room = s.Room.Id;
                                List<string> group = new List<string>();
                                foreach (Group g1 in s.Groups)
                                {
                                    group.Add(g1.ID);
                                }

                                Tuple<DateTime, string, IReadOnlyList<string>> timeTeacherGroups =
                                    new Tuple<DateTime, string, IReadOnlyList<string>>(date, room, group);
                                    

                            }
                        
                    }
                }
            }
            return a;
        }

        public IEnumerable<DateTime> AllExistingDates
        {
            get { return items.Keys; }
        }

        public IReadOnlyDictionary<Tuple<DateTime, LessonsOrder>, IReadOnlyList<Tuple<IRoom, IReadOnlyList<IReadOnlyTeacher>, IReadOnlyList<IReadOnlyGroup>>>> GetWeekData(DateTime dateAtThisWeek)
        {
            throw new NotImplementedException();
        }
    }
}
