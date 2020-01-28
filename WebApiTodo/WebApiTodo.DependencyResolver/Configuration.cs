using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiTodo.DependencyResolver.Dependencies;
namespace WebApiTodo.DependencyResolver
{
  public  class Configuration
    {
        public static IKernel CreateDependencyGraph()
        {
            var kernel = new StandardKernel();
               
            ServiceDependencies.Configure(kernel);
            DataManagerDependencies.Configure(kernel);
           
            return kernel;
        }
    }
}
