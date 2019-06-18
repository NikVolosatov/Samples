using Autofac;
using AutofacModules.Module1.Services;
using System;

namespace AutofacModules.Module1.IoC
{
    public class Module1: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<ServiceModule>();
        }
    }
}
