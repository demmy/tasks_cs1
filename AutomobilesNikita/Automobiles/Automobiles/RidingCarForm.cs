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
        public RidingCarForm(Facade facade)
        {
            InitializeComponent();
            _facade = facade;
        }

        private void RidingCarForm_Load(object sender, EventArgs e)
        {

        }
    }
}
