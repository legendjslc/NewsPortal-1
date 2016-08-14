using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using NewsPortal.BL.Interfaces;
using NewsPortal.BL.Services;
using Ninject;

namespace NewsPortal.Util
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel _kernel;


        public NinjectDependencyResolver(IKernel kernelParam)
        {
            _kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }


        private void AddBindings()
        {
            _kernel.Bind<IBLUnitOfWork>().To<BLUnitOfWork>();
        }
    }
}
