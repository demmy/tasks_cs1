using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    class CalculatorPresenter
    {
        private ICalculatorView view;

        public CalculatorPresenter(ICalculatorView view)
        {
            this.view = view;
        }

        public string Calculate()
        {
            switch (view.Operation)
            {
                case ("+"):
                    return (Convert.ToDouble(view.FirstOperand) + Convert.ToDouble(view.SecondOperand)).ToString();        
   
                case ("-"):
                    return (Convert.ToDouble(view.FirstOperand) - Convert.ToDouble(view.SecondOperand)).ToString();

                case ("*"):
                    return (Convert.ToDouble(view.FirstOperand) * Convert.ToDouble(view.SecondOperand)).ToString();

                case ("/"):
                    return (Convert.ToDouble(view.FirstOperand) / Convert.ToDouble(view.SecondOperand)).ToString();
            }
            return "0";
      
        }
    }
}
