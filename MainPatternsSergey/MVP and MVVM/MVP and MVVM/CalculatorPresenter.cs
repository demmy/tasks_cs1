using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    class CalculatorPresenter
    {
        private ICalculatorModel _model;
        private ICalculatorView _view;
        public CalculatorPresenter(ICalculatorModel model, ICalculatorView view)
        {
            _model = model;
            _view = view;

            view.PropertyChanged += view_onchange;
            view.ExecuteButtonClicked +=
                (sender, args) =>
                {
                    _model.Result = Calc();
                };
            model.PropertyChanged += model_PropertyChanged;

        }

        public string Calc()
        {
            switch (_model.Operator)
            {
                case "+":
                    return (_model.FirstNumber + _model.SecondNumber).ToString();
                case "-":
                    return (_model.FirstNumber - _model.SecondNumber).ToString();
                case "*":
                    return checked (_model.FirstNumber * _model.SecondNumber).ToString();
                case  "/":
                    return _model.SecondNumber != 0 ? (_model.FirstNumber/_model.SecondNumber).ToString() : "NaN";
            }
            return "NaN";
        }
        private void model_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            UpdateViewWithModel();
        }

        private void UpdateViewWithModel()
        {
            _view.FirstNumber = _model.FirstNumber;
            _view.SecondNumber = _model.SecondNumber;
            _view.Operator = _model.Operator;
            _view.Result = _model.Result;
        }

        private void view_onchange(object sender, EventArgs e)
        {
            UpdateModelwithView();
        }

        private void UpdateModelwithView()
        {
            _model.FirstNumber = _view.FirstNumber;
            _model.SecondNumber = _view.SecondNumber;
            _model.Operator = _model.Operator;
            _model.Result = _view.Result;
        }

    }
}
