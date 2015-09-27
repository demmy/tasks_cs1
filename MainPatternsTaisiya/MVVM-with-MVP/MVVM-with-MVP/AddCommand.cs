using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_with_MVP
{
    class AddCommand: ICommand
    { 
        private readonly CalculatorViewModel viewModel;

        public AddCommand(CalculatorViewModel viewModel) 
        {
            this.viewModel = viewModel;
        }
       
        public void Execute()
        {
            try
            {
                switch (viewModel.Operation)
                {
                    case ("+"):
                        viewModel.Display = (Convert.ToDouble(viewModel.FirstOperand) + Convert.ToDouble(viewModel.SecondOperand)).ToString();
                        break;

                    case ("-"):
                        viewModel.Display = (Convert.ToDouble(viewModel.FirstOperand) - Convert.ToDouble(viewModel.SecondOperand)).ToString();
                        break;

                    case ("*"):
                        viewModel.Display = (Convert.ToDouble(viewModel.FirstOperand) * Convert.ToDouble(viewModel.SecondOperand)).ToString();
                        break;

                    case ("/"):
                        viewModel.Display = (Convert.ToDouble(viewModel.FirstOperand) / Convert.ToDouble(viewModel.SecondOperand)).ToString();
                        break;
                }
            }
            catch (Exception)
            {
                viewModel.Display = "Error";
                throw;
            }
        }
    }
}
