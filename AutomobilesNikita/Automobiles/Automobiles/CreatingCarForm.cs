using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobiles
{
    public partial class CreatingCarForm : Form
    {
        private readonly Facade _facade; 

        public CreatingCarForm(Facade facade)
        {
            InitializeComponent();
            _facade = facade;
        }

        private void CreatingCarForm_Load(object sender, EventArgs e)
        {
            carTypeComboBox.DataSource = EnumList.Of<CarType>();
            carTypeComboBox.DisplayMember = "Key";
            carTypeComboBox.SelectedIndex = 0;
        }

        public class EnumList
        {
            public static IEnumerable<KeyValuePair<T, string>> Of<T>()
            {
                return Enum.GetValues(typeof (T))
                    .Cast<T>()
                    .Select(p => new KeyValuePair<T, string>(p, p.ToString()))
                    .ToList();
            }
        }

        private void carTypeComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                createButton_Click(this, e);
            }
            e.SuppressKeyPress = true;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (!IsNameTextBoxValid()) return;
            CreateFactory();
            CreateCar();
            MessageBox.Show(string.Format("Car {0} was created successfully!", nameTextBox.Text), "Car created", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Close();
        }

        private void CreateCar()
        {
            List<ICar> avCars = _facade.AvalaibleCars as List<ICar> ?? new List<ICar>();
            avCars.Add(_facade.CarFactory.CreateCar(nameTextBox.Text));
            _facade.AvalaibleCars = avCars;
        }

        private void CreateFactory()
        {
            _facade.NewFactory((CarType)carTypeComboBox.SelectedIndex);
        }

        private bool IsNameTextBoxValid()
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Car name isn't valid!", "Warning!", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        private void nameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                createButton_Click(this, e);
            }
        }
    }
}