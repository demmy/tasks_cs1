using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_with_MVP
{
    class CalculatorModel
    {
        private string firstOperand;
        private string secondOperand;
        private string operation;


        public CalculatorModel()
        {
        }

        public CalculatorModel(string firstOperand, string secondOperand, string operation)
        {
            this.firstOperand = firstOperand;
            this.secondOperand = secondOperand;
            this.operation = operation;
        }

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
