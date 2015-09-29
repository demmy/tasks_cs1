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
        double[] koefficient = { 0, 2, 2, 5 };
        public double TransmissionStatusKoefficient
        {
            get { return koefficient[(int)Status]; }
        }

        public StatusTransmission Status { get; set; }
        
    }
}
