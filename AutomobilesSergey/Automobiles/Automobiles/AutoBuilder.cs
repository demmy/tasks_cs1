using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automobiles.Automobiles;

namespace Automobiles
{
    /// <summary>
    /// Builder for Cars, implements Builder pattern for application
    /// </summary>
    class AutoBuilder
    {
        public Automobile GetGermanAutomobile(string name, GerModels model)
        {
            return new GermanAutomobile(name, model);
        }
        public Automobile GetUkrainianAutomobile(string name, UkrModels model)
        {
            return new UkrainianAutomobile(name, model);
        }
    }
}
