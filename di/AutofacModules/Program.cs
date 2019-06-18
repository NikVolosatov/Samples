using Autofac;
using AutofacModules.Module2.Abstraction;
using AutofacModules.Module2.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AutofacModules
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<Module2.IoC.Module2>();
            var container = builder.Build();

            var service = container.Resolve<IService2>();

            var model = service.Get();

            Console.WriteLine($"ID - {model.ID}; Name = {model.Name}");
            Console.ReadKey();

        }

    }
}
