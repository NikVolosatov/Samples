using AutofacModules.Core.Interfaces;
using AutofacModules.Module1.Abstraction;
using AutofacModules.Module1.Model;

namespace AutofacModules.Module1.Services
{
    internal class Service1 : IService1, ITransientDependency
    {
        public Model1 Get()
        {
            return new Model1
            {
                Id = 1,
                Name = "Babuta"
            };
        }
    }
}
