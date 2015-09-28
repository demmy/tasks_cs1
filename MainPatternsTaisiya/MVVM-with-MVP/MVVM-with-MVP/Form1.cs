using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVVM_with_MVP
{
    public partial class Form1 : Form
    {
        private CalculatorViewModel viewModel;
        object[] Operations = { '+', '-', '*', '/' };

        public Form1()
        {
            InitializeComponent();
            viewModel = new CalculatorViewModel();
            BindToViewModel();
        }

        private void BindToViewModel()
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = viewModel;
            operationsComboBox.Items.AddRange(Operations);

            firstOperandText.DataBindings.Add("Text", binding, "FirstOperand");
            secondOperandText.DataBindings.Add("Text", binding, "SecondOperand");
            ResultText.DataBindings.Add("Text", binding, "Result");
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            viewModel.Operation = operationsComboBox.SelectedItem.ToString();
            viewModel.CalculateCommand.Execute();
        }

    }
}
