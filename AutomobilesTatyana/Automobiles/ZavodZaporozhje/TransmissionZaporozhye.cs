using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDetails;

namespace ZavodZaporozhye
{
    class TransmissionZaporozhye : ITransmission
    {
        public StatusTransmission Status
        {
            get ; set; 
        }
    }
}
