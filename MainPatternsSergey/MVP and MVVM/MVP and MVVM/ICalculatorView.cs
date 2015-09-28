using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    interface ICalculatorView:INotifyPropertyChanged
    {
        double FirstNumber { get; set; }
        double SecondNumber { get; set; }
        string Operator { get; set; }
        string Result { get; set; }
        event EventHandler ExecuteButtonClicked;
    }
}
