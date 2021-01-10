using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using TODOList.BLL.Abstract;
using TODOList.BLL.Concrete;
using TODOList.Dal.Concrete.Framework.EntityFramework;

namespace TODOList.UI.Ninject
{
    public class NinjectFactory: DefaultControllerFactory
    {
        private readonly IKernel _kernel;

        public NinjectFactory()
        {
            _kernel = new StandardKernel();
            AddBusinessBinding();
        }

        private void AddBusinessBinding()
        {

            _kernel.Bind<IBaseController>().To<BaseController>().WithConstructorArgument("taskDal", new TaskDal());
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)_kernel.Get(controllerType);
        }
    }
}