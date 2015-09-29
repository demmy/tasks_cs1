using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDetails;
using ZavodZaporozhye;

namespace Automobiles
{
    class CarFactory: ICarFactory
    {
        public string ProgrammerName
        {
            get { return "Tatyana"; }
        }

        public ICar CreateCar(string name, InterfacesDetails.IPlant plant)
        {
            Car car = new Car(name, plant.CreateEngine(), plant.CreateTank(), plant.CreateSteeringWheel(), plant.CreateTransmission(),
                                           plant.CreatePedalGas(), plant.CreatePedalBreak(), plant.CreateControlPanel());
            return car;
            
             
        }
    }
}
