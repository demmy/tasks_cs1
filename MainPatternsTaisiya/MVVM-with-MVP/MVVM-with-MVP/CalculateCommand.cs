using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_with_MVP
{
    class CalculateCommand: ICommand
    { 
        private readonly CalculatorViewModel viewModel;

        public CalculateCommand(CalculatorViewModel viewModel) 
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
                        viewModel.Result = (Convert.ToDouble(viewModel.FirstOperand) + Convert.ToDouble(viewModel.SecondOperand)).ToString();
                        break;

                    case ("-"):
                        viewModel.Result = (Convert.ToDouble(viewModel.FirstOperand) - Convert.ToDouble(viewModel.SecondOperand)).ToString();
                        break;

                    case ("*"):
                        viewModel.Result = (Convert.ToDouble(viewModel.FirstOperand) * Convert.ToDouble(viewModel.SecondOperand)).ToString();
                        break;

                    case ("/"):
                        viewModel.Result = (Convert.ToDouble(viewModel.FirstOperand) / Convert.ToDouble(viewModel.SecondOperand)).ToString();
                        break;
                }
            }
            catch (Exception)
            {
                viewModel.Result = "Error";
                throw;
            }
        }
    }
}
