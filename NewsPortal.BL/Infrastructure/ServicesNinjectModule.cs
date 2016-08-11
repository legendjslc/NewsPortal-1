using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsPortal.DAL.Interfaces;
using NewsPortal.DAL.Repositories;
using Ninject.Modules;

namespace NewsPortal.BL.Infrastructure
{
    public class ServicesNinjectModule : NinjectModule
    {
        private string _connectionString;


        public ServicesNinjectModule(string connection)
        {
            _connectionString = connection;
        }


        public override void Load()
        {
            Bind<IDALUnitOfWork>().To<EfUnitOfWork>().WithConstructorArgument(_connectionString);
        }
    }
}
