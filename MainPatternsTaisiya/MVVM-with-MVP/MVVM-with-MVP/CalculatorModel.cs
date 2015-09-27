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
        private string result;


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

        public string Result 
        { 
            get { return result; } 
        }


        public void CalculateResult()
        {
            try
            {
                switch (Operation)
                {
                    case ("+"):
                        result = (Convert.ToDouble(FirstOperand) + Convert.ToDouble(SecondOperand)).ToString();
                        break;

                    case ("-"):
                        result = (Convert.ToDouble(FirstOperand) - Convert.ToDouble(SecondOperand)).ToString();
                        break;

                    case ("*"):
                        result = (Convert.ToDouble(FirstOperand) * Convert.ToDouble(SecondOperand)).ToString();
                        break;

                    case ("/"):
                        result = (Convert.ToDouble(FirstOperand) / Convert.ToDouble(SecondOperand)).ToString();
                        break;
                }
            }
            catch (Exception)
            {
                result = "Error";
                throw;
            }
        }
    }
}
