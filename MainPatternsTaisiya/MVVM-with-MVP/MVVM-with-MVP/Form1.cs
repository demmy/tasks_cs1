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
            BindCommands();
        }

        private void BindToViewModel()
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = viewModel;

            firstOperandText.DataBindings.Add("Text", binding, "FirstOperand");
            secondOperandText.DataBindings.Add("Text", binding, "SecondOperand");
            operationsComboBox.Items.AddRange(Operations);
            //something wrong with binding combobox
            operationsComboBox.DisplayMember = "Operations";
            ResultText.DataBindings.Add("Text", binding, "Display");

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //Because of wrong binding comdodox we should set operation here
            viewModel.Operation = operationsComboBox.SelectedItem.ToString();
            viewModel.AddCommand.Execute();
        }


        private void BindCommands()
        {
            //this work only for devExpress button
            // simpleButton1.BindCommand(() => viewModel.AddCommand.Execute(), viewModel.AddCommand);
 
        }
    }
}
