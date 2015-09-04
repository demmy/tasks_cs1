﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Tatyana
{
    class University : IUniversity
    {
        List<Group> groups;
        List<Teacher> teachers;
        List<Room> rooms;
        Schedule schedule;
        string name;

        public string Name 
                   { get { return name; } }

        public University(string title)
        {
            name = title;
            List<Group> groups = new List<Group>();
            List<Teacher> teachers = new List<Teacher>();
            List<Room> rooms = new List<Room>();
            Schedule schedule = new Schedule();

        }

        public University(string title, List<Group> groups1, List<Teacher> teachers1,
                              List<Room> rooms1, Schedule schedule1)
        {
            name = title;
            groups = groups1;
            teachers = teachers1;
            rooms = rooms1;
            schedule = schedule1;
        }



        public ISchedule CurrentSchedule
        {

            get { return schedule; }
        }

        public IReadOnlyList<string> RoomsNames
        {
            get 
            {
                List<string> roomsNames = new List<string>();
                foreach (Room r in rooms)
                {
                    roomsNames.Add(r.Id);
                }
                return roomsNames;
            }
        }

        public IReadOnlyList<string> TeachersNames
        {
            get 
            {
                List<string> teachersNames = new List<string>();
                foreach(Teacher t in teachers)
                {
                    teachersNames.Add(t.FullName);
                }
                return teachersNames;
            }
        }

        public IReadOnlyList<string> GroupsNames
        {
            get 
            {
                List<string> groupsNames = new List<string>();

                foreach (Group g in groups)
                {
                    groupsNames.Add(g.ID);
                }
                return groupsNames;
            }
        }

        public IReadOnlyList<string> GetStudentsNames(string groupName)
        {
            List<string> studentsNames = new List<string>();
            Group group=null;
            foreach (Group g in groups)
            {
                if (object.Equals(g.ID, groupName))
                {
                    group = g;
                    break;
                }
            }
            if (group != null)
            {
                foreach (Student s in group.Students)
                {
                    studentsNames.Add(s.FullName);
                }
            }
            return studentsNames;
        }
    }
}
