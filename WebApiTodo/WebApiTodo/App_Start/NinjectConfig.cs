using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiTodo.App_Start
{
    using WebApiTodo.DependencyResolver;
    using WebApiTodo.Controllers;
    using Ninject;
    using Ninject.Web.Common.OwinHost;
    using Ninject.Web.WebApi.OwinHost;
    using Owin;
    using System.Web.Http;
    using System.Web.Mvc;

    /// <summary>
    /// Ninject configuration class
    /// </summary>
    internal class NinjectConfig
    {
        #region Private Fields

        /// <summary>
        /// The kernel
        /// </summary>
        private IKernel _kernel;

        #endregion Private Fields

        #region Internal Methods

        internal void ConfigureNinjectKernel(IAppBuilder app)
        {
            _kernel = Configuration.CreateDependencyGraph();

            app.UseNinjectMiddleware(() => _kernel);

            ControllerBuilder.Current.SetControllerFactory(new InjectorControllerFactory(_kernel));
        }

        internal void ConfigureNinjectWebApi(IAppBuilder app, HttpConfiguration config)
        {
            app.UseNinjectWebApi(config);
        }

        #endregion Internal Methods
    }
}