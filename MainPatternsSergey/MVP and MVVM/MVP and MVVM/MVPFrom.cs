using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace MVP
{
    public partial class MvpForm : Form, ICalculatorView
    {

        public MvpForm()
        {
            InitializeComponent();
        }

        public double FirstNumber
        {
            get { return double.Parse(FirstNumberTextBox.Text); }
            set { FirstNumberTextBox.Text = value.ToString(CultureInfo.CurrentCulture); }
        }

        public double SecondNumber
        {
            get { return double.Parse(SecondNumberTextBox.Text); }
            set { SecondNumberTextBox.Text = value.ToString(CultureInfo.CurrentCulture); }
        }

        public string Operator { get { return CommandComboBox.SelectedItem.ToString(); } set
        {
            CommandComboBox.SelectedItem = value;
        } }
        public string Result { get { return ResultTextBox.Text; } 
            set { ResultTextBox.Text = value; } }

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler ExecuteButtonClicked;

        void Execute_Click(object sender, EventArgs e)
        {
            if (ExecuteButtonClicked != null) 
                ExecuteButtonClicked(sender, e);
        }

        private void FirstNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (null != PropertyChanged)
                PropertyChanged(this, new PropertyChangedEventArgs("FirstNumber"));

        }

        private void SecondNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (null != PropertyChanged)
                PropertyChanged(this, new PropertyChangedEventArgs("SecondNumber"));
        }

        private void ResultTextBox_TextChanged(object sender, EventArgs e)
        {
            if (null != PropertyChanged)
                PropertyChanged(this, new PropertyChangedEventArgs("Result"));
        }

        private void CommandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null != PropertyChanged)
                PropertyChanged(this, new PropertyChangedEventArgs("Operator"));
        }
    }
}
