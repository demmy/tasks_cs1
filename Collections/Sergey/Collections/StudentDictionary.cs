using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Collections.Sergey.Models;

namespace Collections.Sergey.Collections
{
    class StudentDictionary : KeyedCollection<Tuple<string, string>, Student>
    {
        private static Tuple<string, string> _keyParam = new Tuple<string, string>();
        protected override Tuple<string, string> GetKeyForItem(Student item)
        {
            _keyParam.Item1 = item.FirstName;
            _keyParam.Item2 = item.FamilyName;
            return _keyParam;
        }
    }
}
