using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    interface IUniversity
    {
        ISchedule CurrentSchedule { get; }
    }
}
