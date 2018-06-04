using System;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.DependencyInjection;

namespace Samples.WebJobs.Core
{
    public class CustomJobActivator : IJobActivator
    {
        private readonly IServiceProvider _service;
        public CustomJobActivator(IServiceProvider service)
        {
            _service = service;
        }

        public T CreateInstance<T>()
        {
            var service = _service.GetService<T>();
            return service;
        }
    }
}