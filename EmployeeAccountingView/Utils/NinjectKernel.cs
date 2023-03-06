using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccountingView.Utils
{
    public class NinjectKernel
    {
        private static StandardKernel? instance;

        private NinjectKernel() { }

        public static StandardKernel GetInstance()
        {
            if (instance == null)
            {
                instance = new StandardKernel(new Bindings());
            }

            return instance;
        }
    }
}
