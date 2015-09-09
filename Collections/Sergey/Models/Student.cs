using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections.Sergey.Models
{
    class Student: User
    {  
        public string FirstName
        {
            get
            {
                return _firstName;
            }
        }

        public string FamilyName 
        {
            get
            {
                return _familyName;
            }
        }
    }
}
