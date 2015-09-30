using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDetails;

namespace ZavodZaporozhye
{
    class ControlPanelZaporozhye : IControlPanelInner
    {

        public double Speed   { get;  set;  }

        public double Direction  {   get;   set;   }

        public double RemainderFuel { get; set; }
    }
}
