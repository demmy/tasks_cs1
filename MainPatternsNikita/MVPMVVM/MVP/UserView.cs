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
    public partial class UserView : Form, IUserView
    {
        public UserView()
        {
            InitializeComponent();
        }

        private void View_Load(object sender, EventArgs e)
        {
            operationComboBox.SelectedIndex = 0;
        }

        private void operationComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void firstOperandTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar);
        }

        private void secondOperandTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar);
        }

        public TextBox FirstOperandTextBox
        {
            get { return this.firstOperandTextBox; }
            set { firstOperandTextBox = value; }
        }

        public TextBox SecondOperandTextBox
        {
            get { return secondOperandTextBox; }
            set { secondOperandTextBox = value; }
        }

        public TextBox ResultTextBox
        {
            get { return resultTextBox; }
            set { resultTextBox = value; }
        }

        public ComboBox OperationComboBox
        {
            get { return operationComboBox; }
            set { operationComboBox = value; }
        }

        public Button CalculateButton
        {
            get { return this.calculateButton; }
            set { this.calculateButton = value; }
        }
        
    }

    public interface IUserView
    {
        TextBox FirstOperandTextBox { get; set; }
        TextBox SecondOperandTextBox { get; set; }
        TextBox ResultTextBox { get; set; }
        ComboBox OperationComboBox { get; set; }
        Button CalculateButton { get; set; }
        void Show();
        void Close();
    }
}
