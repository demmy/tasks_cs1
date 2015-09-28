using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    class CalculatorModel : ICalculatorModel
    {
        private double _firstNumber;
        private double _secondNumber;
        private string _operator;
        private string _result;

        public double FirstNumber
        {
            get { return _firstNumber; }
            set
            {
                _firstNumber = value;
                Act("FirstNumber");
            }
        }

        private void Act(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public double SecondNumber
        {
            get
            {
                return _secondNumber;
            }
            set
            {
                _secondNumber = value;
                Act("SecondNumber");
            }
        }

        public string Operator
        {
            get { return _operator; }
            set
            {
                _operator = value;
                Act("Operator");
            }
        }

        public string Result
        {
            get
            {
                return _result;
            }
            set
            {
                _result = value;
                Act("Result");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
