using EmployeeAccountingBusinessLogic.BusinessLogic;
using EmployeeAccountingBusinessLogic.Interfaces;
using Ninject;
using System.Reflection;

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
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain(kernel.Get<EmployeeLogic>()));
        }
    }
}