using EmployeeAccountingView.Utils;
using Ninject;

namespace EmployeeAccountingView
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(NinjectKernel.GetInstance().Get<FormMain>());
        }
    }
}