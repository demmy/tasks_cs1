using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    class CalculatorPresenter
    {
        private ICalculatorModel model;
        private ICalculatorView view;

        public CalculatorPresenter(ICalculatorModel model, ICalculatorView view)
        {
            this.model = model;
            this.view = view;
        }
    }
}
