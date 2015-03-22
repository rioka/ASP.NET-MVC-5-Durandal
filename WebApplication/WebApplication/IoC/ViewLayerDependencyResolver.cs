﻿using Ninject;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication.BLL.Managers;

namespace WebApplication.IoC
{
    public class ViewLayerDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public ViewLayerDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
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
            kernel.Bind<IAdminManager>().To<AdminManager>();
        }
    }
}