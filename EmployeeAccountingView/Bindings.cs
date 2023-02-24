﻿using EmployeeAccountingBusinessLogic.Interfaces;
using EmployeeAccountingDatabase.Implements;
using Ninject.Modules;

namespace EmployeeAccountingView
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IEmployeeStorage>().To<EmployeeStorage>();
        }
    }
}