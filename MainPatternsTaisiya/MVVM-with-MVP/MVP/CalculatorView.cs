using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    class CalculatorView: ICalculatorView
    {
        private string firstOperand;
        private string secondOperand;
        private string operation;


        public string FirstOperand
        {
            get { return firstOperand; }
            set { firstOperand = value; }
        }

        public string SecondOperand
        {
            get { return secondOperand; }
            set { secondOperand = value; }
        }

        public string Operation
        {
            get { return operation; }
            set { operation = value; }
        }

        
    }
}
