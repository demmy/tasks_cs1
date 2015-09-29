using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDetails
{
    public  enum StatusTransmission { Stop, Forward, Ago, MaxSpeed, AfterLastPosotion }

    public interface ITransmission
    {
        double TransmissionStatusKoefficient { get; }
        StatusTransmission Status { get; set; }
    }
}
