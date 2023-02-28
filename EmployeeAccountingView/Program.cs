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
            var kernel = new StandardKernel(new Bindings());
            ApplicationConfiguration.Initialize();
            Application.Run(kernel.Get<FormMain>());
        }
    }
}