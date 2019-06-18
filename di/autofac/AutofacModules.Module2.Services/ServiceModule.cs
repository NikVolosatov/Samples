using Autofac;
using AutofacModules.Core.Interfaces;
using System;
using System.Linq;
using System.Reflection;
using Module = Autofac.Module;

namespace AutofacModules.Module2.Services
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
             .RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
             .Where(x => x.GetInterfaces().Contains(typeof(ITransientDependency)))
             .AsImplementedInterfaces();
        }
    }
}
