using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDetails
{
    public interface IPlant
    {

        string ProgrammerName { get; }
        IEngine CreateEngine();
        ITank CreateTank();
        ISteeringWheel CreateSteeringWheel();
        ITransmission CreateTransmission();
        IPedal CreatePedalGas();
        IPedal CreatePedalBreak();
        IControlPanel CreateControlPanel();


    }
}
