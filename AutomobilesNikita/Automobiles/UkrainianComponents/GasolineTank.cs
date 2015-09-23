using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComponentsInterfaces;

namespace UkrainianComponents
{
    public class GasolineTank : IGasolineTank
    {
        private double _fuelAmount = 35;
        private int _fuelRoominess = 35;

        public GasolineTank()
        {

        }
        
        public double FuelAmount
        {
            get { return _fuelAmount; }
            set { _fuelAmount = value; }
        }

        public int FuelRoominess
        {
            get { return _fuelRoominess; }
            set { _fuelRoominess = value; }
        }
    }
}