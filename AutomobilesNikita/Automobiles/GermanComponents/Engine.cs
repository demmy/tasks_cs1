
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComponentsInterfaces;

namespace GermanComponents
{

    public class Engine : IEngine
    {
        public Engine()
        {
        }
        private int _fuelSpendingPer100km = 12;
        private int _horsePower = 350;

        public int FuelSpendingPer100Km
        {
            get { return _fuelSpendingPer100km; }
            set { _fuelSpendingPer100km = value; }
        }

        public int HorsePower
        {
            get { return _horsePower; }
            set { _horsePower = value; }
        }
    }
}