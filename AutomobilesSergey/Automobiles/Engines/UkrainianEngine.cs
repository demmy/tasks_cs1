using System;
using System.Threading;
using FuelTanks;
using Gearboxes;
using GearBoxes;

namespace Engines
{
    public class UkrainianEngine:IEngine
    {
        private Timer _timer;
        public IFuelTank Tank { get; private set; }
        public IGearbox Gearbox { get; private set; }

        public UkrainianEngine()
        {
            Tank = new UkrainianFuelTank();
            Gearbox = new UkrainianGearBox();
        } 

        public void Start()
        {
            _timer = new Timer(FuelOnTiming, Tank, 1000, 15000);
        }

        public void Stop()
        {
            _timer.Dispose();
        }

        private static void FuelOnTiming(object sender)
        {
            var tank = sender as IFuelTank;
            if (tank != null) tank.Capacity -= 0.3;
        }
    }
}
