using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDetails
{
     public interface ITank
    {
        double Content { get; }
        double Remainder { get; }
        void Add(double countFuel);
        void Clear(double countFuel);
        void Expend(double countFuel);
        void Fill();
        bool IsFuel { get; }
    }
}
