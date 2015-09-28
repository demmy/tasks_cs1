using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles
{
    interface ICar
    {
        string CarName { get; set; }
        void AcceleratorPedal();
        void BreakPedal();
        void TurnSteeringWheelLeft();
        void TurnSteeringWheelRight();
        bool Lights();
        void ShowDashboard();
    }
}
