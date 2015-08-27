﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    interface IReadOnlyGroup
    {
        string ID { get; }
        FacultyType Faculty { get;  }
        IEnumerable<IReadOnlyPerson> Students { get;  }
    }
}
