using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComponentsInterfaces
{
    public interface IGasolineTank
    {
        int FuelAmount { get; set; }
        int FuelRoominess { get; set; }
    }
}