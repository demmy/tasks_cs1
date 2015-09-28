using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles.Cars
{
    class GermanCar: ICar
    {
        public string CarName { get; set; }
        public GermanCarModels Model { get; set; }
        public bool Status { get; set; }
        
        const int speed = 300;
        const int treadleEffort = 20;
        const int gearNubmer = 12;
        const int angleDegree = 5;
        const int volumetricCapability = 150;

        Interfaces.IDashboard Dashboard = new Models.Dashboard();
        Interfaces.IFuelTank FuelTank = new Models.FuelTank(volumetricCapability);
        Interfaces.ISteeringWheel SteeringWheel = new Models.SteeringWheel();
        Interfaces.IGearBox GearBox = new Models.GearBox(gearNubmer);
        Interfaces.IPedal Pedal= new Models.Pedal(treadleEffort);
        Interfaces.IMotor Motor= new Models.Motor(speed);


        public GermanCar(string carName, GermanCarModels model)
        {
            CarName = carName;
            Model = model;
            Status = false;
        }

        public void AcceleratorPedal()
        {
            if (Motor.CurrentSpeed <= speed && FuelTank.CurrentVolumetricCapability >= FuelTank.VolumetricCapability * Motor.CurrentSpeed / (treadleEffort * 100))
            {
                Motor.CurrentSpeed += Motor.MaxSpeed / 10;
                FuelTank.CurrentVolumetricCapability -= FuelTank.VolumetricCapability * Motor.CurrentSpeed / (treadleEffort * 100);
            }
            else
            {
                Motor.CurrentSpeed = 0;
                FuelTank.CurrentVolumetricCapability = 0;
            }
            
        }

        public void BreakPedal()
        {
            if (Motor.CurrentSpeed >= Motor.MaxSpeed / 10 || FuelTank.CurrentVolumetricCapability >= FuelTank.VolumetricCapability * Motor.CurrentSpeed / (treadleEffort * 200))
            {
                Motor.CurrentSpeed -= Motor.MaxSpeed / 10;
                FuelTank.CurrentVolumetricCapability -= FuelTank.VolumetricCapability * Motor.CurrentSpeed / (treadleEffort * 200);
            }
            else
            {
                Motor.CurrentSpeed = speed;
                FuelTank.CurrentVolumetricCapability = 0;
            }
        }

        public void TurnSteeringWheelLeft()
        {
            SteeringWheel.AngleDegree += angleDegree;
        }

        public void TurnSteeringWheelRight()
        {
            SteeringWheel.AngleDegree -= angleDegree;
        }

        public bool Lights()
        {
            return !Status;
        }

        public void ShowDashboard()
        {
            Dashboard.ShowSpeed(Motor.CurrentSpeed);
            Dashboard.ShowFuelQuantity(FuelTank.CurrentVolumetricCapability);
            Dashboard.ShowDirection(SteeringWheel.AngleDegree);
            Dashboard.ShowLightsStatus(Status);
        }
    }
}
