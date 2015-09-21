using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using Collections.Sergey.Models;

namespace Collections.Sergey.Collections
{
    class StudentDictionary : KeyedCollection<Tuple<string, string>, Student>
    {
        protected override Tuple<string, string> GetKeyForItem(Student item)
        {
            return new Tuple<string, string>(item.FirstName, item.FamilyName);
        }

        public IEnumerable<Tuple<string, string>> Keys
        {
            get { return Dictionary.Keys; }
        }
    }
}
