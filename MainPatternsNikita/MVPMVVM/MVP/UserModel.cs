using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    class UserModel : IUserModel
    {
        public event EventHandler<OperationEventArgs> OperationCompleted  = delegate(object sender, OperationEventArgs args) {  };

        public void Addition(double op1, double op2)
        {
            OperationCompleted(this, new OperationEventArgs(op1+op2));
        }

        public void Subtraction(double op1, double op2)
        {
            OperationCompleted(this, new OperationEventArgs(op1 - op2));
        }

        public void Multiplication(double op1, double op2)
        {
            OperationCompleted(this, new OperationEventArgs(op1 * op2));
        }

        public void Division(double op1, double op2)
        {
            OperationCompleted(this, new OperationEventArgs(op1 / op2));
        }
    }

    interface IUserModel
    {
        event EventHandler<OperationEventArgs> OperationCompleted;
        void Addition(double op1, double op2);
        void Subtraction(double op1, double op2);
        void Multiplication(double op1, double op2);
        void Division(double op1, double op2);
    }

    class OperationEventArgs : EventArgs
    {
        public double Result { get; private set; }

        public OperationEventArgs(double result)
        {
            Result = result;
        }
    }
}
