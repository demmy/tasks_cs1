
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComponentsInterfaces;

namespace UkrainianComponents
{

    public class Engine : IEngine
    {
        public Engine()
        {
        }
        private int _fuelSpendingPer100Km = 16;
        private int _horsePower = 350;

        public int FuelSpendingPer100Km
        {
            get { return _fuelSpendingPer100Km; }
            set { _fuelSpendingPer100Km = value; }
        }

        public int HorsePower
        {
            get { return _horsePower; }
            set { _horsePower = value; }
        }
    }
}