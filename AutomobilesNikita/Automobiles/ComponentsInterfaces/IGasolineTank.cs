using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComponentsInterfaces
{
    public interface IGasolineTank
    {
        double FuelAmount { get; set; }
        int FuelRoominess { get; set; }
    }
}