using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTodo.DependencyResolver.Dependencies
{
    using Ninject;
    using WebApiTodo.Model;
    internal static class DataManagerDependencies
    {
        internal static void Configure(IKernel kernel)
        {
            kernel.Bind<IUser>().To<User>();
            kernel.Bind<ITodoTask>().To<TodoTask>();
        }
    }
}
