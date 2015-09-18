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
        private Facade _facade;
        public CreatingCarForm(Facade facade)
        {
            InitializeComponent();
            _facade = facade;
        }

        private void CreatingCarForm_Load(object sender, EventArgs e)
        {

        }
    }
}
