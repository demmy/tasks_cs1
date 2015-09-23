using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComponentsInterfaces;

namespace GermanComponents
{
    public class ControlPanel : IControlPanel
    {
        public ControlPanel()
        {
        }

        private string _color = "Black";

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
    }
}