using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace University
{
    enum PositionType { Professor, Lector, Assistant, AfterLastPosition };

    interface IReadOnlyTeacher: IReadOnlyPerson
    {
        PositionType Position { get;  }
    }
}
