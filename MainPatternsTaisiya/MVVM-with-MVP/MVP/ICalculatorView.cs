using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    interface ICalculatorView
    {

        string FirstOperand { get; set; }
        string SecondOperand { get; set; }
        string Operation { get; set; }

    }
}
