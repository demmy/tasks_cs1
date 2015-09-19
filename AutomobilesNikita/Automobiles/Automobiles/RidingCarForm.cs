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
    public partial class RidingCarForm : Form
    {
        private Facade _facade;
        private ICar _ridingCar;
        private Timer _timer;

        public RidingCarForm(Facade facade)
        {
            InitializeComponent();
            _facade = facade;
        }

        private void RidingCarForm_Load(object sender, EventArgs e)
        {
            carsListBox.DataSource = _facade.AvalaibleCars;
        }

        private void selectCarButton_Click(object sender, EventArgs e)
        {
            if (carsListBox.SelectedItem == null)
            {
                MessageBox.Show("No car to choose", "Attention!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            _ridingCar = (ICar)carsListBox.SelectedItem;
            RefreshCarState(this, new CarEventArgs("Refreshing"));
        }

        private void RefreshCarState(object sender, EventArgs eventArgs)
        {
            nameLabel.Text = string.Format("Name: {0}", _ridingCar.Name);
            speedLabel.Text = string.Format("Speed: {0:N}", _ridingCar.Speed);
            fuelLabel.Text = string.Format("Fuel: {0:N}", _ridingCar.Fuel);
            directionLabel.Text = string.Format("Direction: {0}", _ridingCar.Direction);
            lightsLabel.Text = string.Format("Lights: {0}", _ridingCar.Lights);
        }

        private void accelerateButton_Click(object sender, EventArgs e)
        {
            if(_ridingCar == null) return;
            _ridingCar.PressAccelerator((int) accleratorPowerNumericUpDown.Value);
        }

        private void brakesButton_Click(object sender, EventArgs e)
        {
            if (_ridingCar == null) return;
            _ridingCar.PressBrakes((int) brakesPowerNumericUpDown.Value);
        }

        private void wheelToLeftButton_Click(object sender, EventArgs e)
        {
            if (_ridingCar == null) return;
            _ridingCar.RotateSteeringWheelLeft((int) rotationToLeftNumericUpDown.Value);
        }

        private void wheelToRightButton_Click(object sender, EventArgs e)
        {
            if (_ridingCar == null) return;
            _ridingCar.RotateSteeringWheelRight((int) rotationToRightNumericUpDown.Value);
        }

        private void lightsButton_Click(object sender, EventArgs e)
        {
            if (_ridingCar == null) return;
            switch (_ridingCar.Lights)
            {
                case Lights.Off:
                    _ridingCar.TurnOnFarLights();
                    break;
                case Lights.Far:
                    _ridingCar.TurnOnCloseLights();
                    break;
                case Lights.Close:
                    _ridingCar.TurnOffLights();
                    break;
            }
            RefreshCarState(sender, e);
        }

        private void rideButton_Click(object sender, EventArgs e)
        {
            _timer = new Timer {Interval = 1000, Enabled = true};
            _timer.Tick += _ridingCar.RefreshCarState;
            _timer.Tick += RefreshCarState;
            _ridingCar.FuelEnded += delegate { MessageBox.Show("Oops, fuel ended!"); };
            _ridingCar.CarStopped += delegate { MessageBox.Show("Oops, car stopped!"); };
            RefreshCarState(sender, e);
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Leaving..", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.No) return;
            _ridingCar.Speed = 0;
            _timer.Stop();
            _timer.Tick -= _ridingCar.RefreshCarState;
            _timer.Tick -= RefreshCarState;
            FindCarAndRefreshItsState();
            CleanCarState();
        }

        private void FindCarAndRefreshItsState()
        {
            List<ICar> cars = (List<ICar>) _facade.AvalaibleCars;
            cars[cars.FindIndex(c => c.Name == _ridingCar.Name)] = _ridingCar;
            _facade.AvalaibleCars = cars;
        }

        private void CleanCarState()
        {
            nameLabel.Text = string.Format("Name: ");
            speedLabel.Text = string.Format("Speed: ");
            fuelLabel.Text = string.Format("Fuel: ");
            directionLabel.Text = string.Format("Direction: ");
            lightsLabel.Text = string.Format("Lights: ");
        }
    }
}
