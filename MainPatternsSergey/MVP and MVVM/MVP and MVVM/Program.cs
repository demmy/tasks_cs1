using System;
using System.Windows.Forms;

namespace MVP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ICalculatorModel model = new CalculatorModel();
            ICalculatorView view = new MvpForm();
            var presenter = new CalculatorPresenter(model, view);
            Application.Run((Form)view);
        }
    }
}
