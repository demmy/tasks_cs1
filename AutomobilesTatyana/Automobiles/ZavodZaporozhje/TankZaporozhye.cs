using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDetails;

namespace ZavodZaporozhye
{
    class TankZaporozhye : ITank
    {
        double fuel=0;
        public double Content
        {
            get { return 25; }
        }

        public double Remainder
        {
            get 
            {
                return Content - fuel; 
            }
        }

        public void Add(double countFuel)
        {
            fuel+=countFuel;
            if (fuel > Content)
            {
                fuel = Content;
            }
        }

        public void Clear(double countFuel)
        {
            fuel = 0;
        }

        public void Expend(double countFuel)
        {
            fuel -= countFuel;
            if (fuel < 0)
            {
                fuel = 0;
            }
        }

        public void Fill()
        {
            fuel = Content;
        }

        public bool IsFuel
        {
            get { return fuel > 0 ? true : false; }
        }
    }
}
