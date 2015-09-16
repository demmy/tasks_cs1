using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Sergey.Models
{
    class Group : IReadOnlyGroup
    {
        public string ID { get; private set; }
        public FacultyType Faculty { get; private set; }
        public IEnumerable<IReadOnlyPerson> Students { get; private set; }
    }
}
