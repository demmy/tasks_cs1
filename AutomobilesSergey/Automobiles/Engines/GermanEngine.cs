using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FuelTanks;
using Gearboxes;
using GearBoxes;

namespace Engines
{
    public class GermanEngine:IEngine
    {
        private Timer _timer;
        public IFuelTank Tank { get; private set; }
        public IGearbox Gearbox { get; private set; }

        public GermanEngine()
        {
            Gearbox = new GermanGearBox();
            Tank = new GermanFuelTank();
        } 

        public void Start()
        {
            _timer = new Timer(FuelOnTiming, Tank, 1000, 16000);
        }

        public void Stop()
        {
            _timer.Dispose();
        }

        private static void FuelOnTiming(object sender)
        {
            var tank = sender as IFuelTank;
            if (tank != null) tank.Capacity -= 0.26;
        }
    }
}
