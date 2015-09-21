using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MVP
{
    class UserPresenter
    {
        private IUserView _view;
        private IUserModel _model;

        private double operationResult;

        public UserPresenter(IUserView view, IUserModel model)
        {
            _view = view;
            _model = model;
            _view.CalculateButton.Click += calculateButton_Click;
            _model.OperationCompleted += OperationCompletedHandler;
        }

        public void Run()
        {
            Application.Run((Form) _view);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            switch ((string)_view.OperationComboBox.SelectedItem)
            {
                case "Addition":
                {
                    _model.Addition(Convert.ToDouble(_view.FirstOperandTextBox.Text), Convert.ToDouble(_view.SecondOperandTextBox.Text));
                    break;
                }
                case "Subtraction":
                {
                    _model.Subtraction(Convert.ToDouble(_view.FirstOperandTextBox.Text), Convert.ToDouble(_view.SecondOperandTextBox.Text));
                    break;
                }
                case "Multiplication":
                {
                    _model.Multiplication(Convert.ToDouble(_view.FirstOperandTextBox.Text), Convert.ToDouble(_view.SecondOperandTextBox.Text));
                    break;
                }
                case "Division":
                {
                    _model.Division(Convert.ToDouble(_view.FirstOperandTextBox.Text), Convert.ToDouble(_view.SecondOperandTextBox.Text));
                    break;
                }
            }
        }

        private void OperationCompletedHandler(object sender, OperationEventArgs e)
        {
            operationResult = e.Result;
            RefreshView();
        }

        private void RefreshView()
        {
            _view.ResultTextBox.Text = operationResult.ToString();
        }
    }
}
