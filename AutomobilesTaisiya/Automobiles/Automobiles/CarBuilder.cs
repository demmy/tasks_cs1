using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles
{
    enum GermanCarModels { BMW, Mini}
    enum UkrainianCarModels { ZAZ, LADA }

    class CarBuilder
    {
        public Cars.GermanCar CreateGermanCar(string name, GermanCarModels model)
        {
            return new Cars.GermanCar(name, model);
        }

        public Cars.UkrainianCar CreateUkrainianCar(string name, UkrainianCarModels model)
        {
            return new Cars.UkrainianCar(name, model);
        }

        
    }
}
