using System;
using System.Collections.ObjectModel;
using Collections.Sergey.Models;

namespace Collections.Sergey.Collections
{
    class StudentDictionary : KeyedCollection<Tuple<string, string>, Student>
    {
        protected override Tuple<string, string> GetKeyForItem(Student item)
        {
            return new Tuple<string, string>(item.FirstName, item.FamilyName);
        }
    }
}
