using System;
using System.Collections.Generic;
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
        public IAutomobile GetGermanAutomobile(string name)
        {
            return new GermanAutomobile();
        }
        public IAutomobile GetUkrainianAutomobile(string name)
        {
            return new UkrainianAutomobile();
        }
    }
}
