using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    enum FacultyType {IT, Economics, Physics, Languages };
    enum SpecialityTitle { ComputerScience, ComputerSecurity, Marketing, Management, QuantumPhysics, AppliedPhysics, English, German};
    enum PositionType { Professor, Lector, Assistant };

    interface IUniversity
    {
        ISchedule CurrentSchedule { get; }
    }
}
