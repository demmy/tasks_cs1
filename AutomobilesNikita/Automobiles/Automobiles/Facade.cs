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
        private CreatingCarForm _ccf;
        private List<ICar> _avalaibleCars = new List<ICar>();
        private ICarFactory _carFactory;

        public Facade()
        {
            InitializeComponent();
        }

        private void Facade_Load(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            _ccf = new CreatingCarForm(this);
            _ccf.ShowDialog();
        }

        public ICarFactory CarFactory
        {
            get { return _carFactory; }
        }

        public void NewFactory(CarType ct)
        {
            _carFactory = new Factory(ct);
        }

        public List<ICar> AvalaibleCars
        {
            get { return _avalaibleCars;  }
            set { _avalaibleCars = (List<ICar>) value; }
        }
    }
}