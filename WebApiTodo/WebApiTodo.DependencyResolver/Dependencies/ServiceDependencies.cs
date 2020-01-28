using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTodo.DependencyResolver.Dependencies
{
   
    using Ninject;
    using WebApiTodo.Service;
    internal static class ServiceDependencies
    {
        internal static void Configure(IKernel kernel)
        {
            kernel.Bind<IServiceContainer>().To<ServiceContainer>();
        }
    }
}
