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
            Car car = new Car(name);
            car.Engine = plant.CreateEngine();
            car.Tank = plant.CreateTank();
            car.SteeringWheel = plant.CreateSteeringWheel();
            car.Transmission = plant.CreateTransmission();
            car.PedalGas = plant.CreatePedalGas();
            car.PedalBreak = plant.CreatePedalBreak();
            car.ControlPanel = plant.CreateControlPanel();
            return car;
            
             
        }
    }
}
