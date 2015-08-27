using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    enum PositionType { Professor, Lector, Assistant };

    interface IReadOnlyTeacher: IReadOnlyPerson
    {
        PositionType Position { get;  }
    }
}
