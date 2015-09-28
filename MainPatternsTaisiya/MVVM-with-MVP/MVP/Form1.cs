using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP
{
    public partial class Form1 : Form, ICalculatorView
    {
        public Form1()
        {
            InitializeComponent();
        }

        CalculatorPresenter presenter = new CalculatorPresenter(new CalculatorView());

        public string FirstOperand
        {
            get
            {
                return firstOperandText.ToString();
            }
            set
            {
                firstOperandText.Text = value;
            }
        }

        public string SecondOperand
        {
            get
            {
                return secondOperandText.ToString();
            }
            set
            {
                secondOperandText.Text = value;
            }
        }

        public string Operation
        {
            get
            {
                return operationsComboBox.SelectedItem.ToString();
            }
            set
            {
                operationsComboBox.SelectedItem = value;
            }
        }
    }
}
