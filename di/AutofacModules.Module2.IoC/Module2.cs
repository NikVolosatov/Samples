using Autofac;
using AutofacModules.Module2.Services;
using System;

namespace AutofacModules.Module2.IoC
{
    public class Module2: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<Module1.IoC.Module1>();
            builder.RegisterModule<ServiceModule>();
        }
        
    }
}
