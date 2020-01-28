using Ninject;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApiTodo.Controllers
{
    public class InjectorControllerFactory : DefaultControllerFactory
    {
        /// <summary>
        /// The injector
        /// </summary>
        private IKernel _injector;

        /// <summary>
        /// Initializes a new instance of the <see cref="InjectorControllerFactory"/> class.
        /// </summary>
        /// <param name="injector">The injector.</param>
        public InjectorControllerFactory(IKernel injector)
        {
            _injector = injector;
        }

        /// <summary>
        /// Retrieves the controller instance for the specified request context and controller type.
        /// </summary>
        /// <param name="requestContext">The context of the HTTP request, which includes the HTTP context and route data.</param>
        /// <param name="controllerType">The type of the controller.</param>
        /// <returns>
        /// The controller instance.
        /// </returns>
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            var controller = _injector.Get(controllerType);

            return controller as IController;
        }
    }
}