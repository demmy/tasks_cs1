using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDetails;

namespace ZavodGermany
{
    class TransmissionGermany : ITransmission
    {
        public StatusTransmission Status
        {
            get ; set; 
        }
    }
}
