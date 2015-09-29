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
        double[] koefficient = { 0, 1, 1, 2 }; 
        public double TransmissionStatusKoefficient
        {
            get { return koefficient[(int)Status]; }
        }

        public StatusTransmission Status {  get;  set;  }
    }
}
