using AutofacModules.Core.Interfaces;
using AutofacModules.Module1.Abstraction;
using AutofacModules.Module1.Model;
using AutofacModules.Module2.Abstraction;
using AutofacModules.Module2.Model;
using System;

namespace AutofacModules.Module2.Services
{
    internal class Service2 : IService2, ITransientDependency
    {
        private IService1 _service;
        public Service2(IService1 service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }
        public Model2 Get()
        {
            var model1 = _service.Get();
            return new Model2
            {
                ID = model1.Id + 1,
                Name = model1.Name + "2"
            };
        }
    }
}
