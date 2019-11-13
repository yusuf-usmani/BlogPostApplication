using BLL;
using DAL;
using Ninject;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace BlogPostApp
{
    /// <summary>
    /// class to resolve interfaces for dependency injection
    /// </summary>
    public class DependencyInjectionResolver : IDependencyResolver
    {
        private IKernel kernel;
        public DependencyInjectionResolver()
        {
            kernel = new StandardKernel();
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<IBlogBS>().To<BlogBS>();
            kernel.Bind<IUserBS>().To<UserBS>();
            kernel.Bind<IBlogsDb>().To<BlogsDb>();
            kernel.Bind<IUserDb>().To<UserDb>();
        }
    }
}

