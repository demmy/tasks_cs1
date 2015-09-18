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
    public enum CarType
    {
        Ukrainian, German
    }

    public partial class Facade : Form
    {
        private List<ICar> _avalaibleCars = new List<ICar>();
        private ICarFactory _carFactory;

        public Facade()
        {
            InitializeComponent();
        }

        private void Facade_Load(object sender, EventArgs e)
        {

        }

        public Car GetCarForARide(string name, CarType t)
        {

        }

        public Form RideACar(Car c)
        {

        }

    }
}