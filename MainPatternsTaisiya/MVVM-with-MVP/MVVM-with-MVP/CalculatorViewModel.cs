using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace MVVM_with_MVP
{
    class CalculatorViewModel: INotifyPropertyChanged
    {
        private CalculatorModel calculation;
        private string result;
        private CalculateCommand calculateCommand;


        public event PropertyChangedEventHandler PropertyChanged;
        private CalculateCommand addCommand;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        public CalculatorViewModel()
        {
            this.calculation = new CalculatorModel();
            this.result = "0";
            this.FirstOperand = string.Empty;
            this.SecondOperand = string.Empty;
            this.Operation = string.Empty;
           
            calculateCommand = new CalculateCommand(this);
        }


        public string FirstOperand
        {
            get { return calculation.FirstOperand; }
            set { calculation.FirstOperand = value; }
        }

        public string SecondOperand
        {
            get { return calculation.SecondOperand; }
            set { calculation.SecondOperand = value; }
        }

        public string Operation
        {
            get { return calculation.Operation; }
            set { calculation.Operation = value; }
        }

        public string Result
        {
            get { return result; }
            set
            {
                result = value;
                OnPropertyChanged("Result");
            }
        }

        public ICommand CalculateCommand
        {
            get { return calculateCommand; }
        }
    }
}
