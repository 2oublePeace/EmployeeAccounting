using Ninject;

namespace EmployeeAccountingView.Utils
{
    public class NinjectKernel
    {
        private static StandardKernel? instance;
        private NinjectKernel() { }
        public static StandardKernel GetInstance()
        {
            return instance ??= new StandardKernel(new Bindings());
        }
    }
}
