using Ninject.Modules;
using syseng_back.DAL.Interfaces;
using syseng_back.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syseng_back.BLL.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        private string connectionString;
        public ServiceModule(string connection)
        {
            connectionString = connection;
        }
        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}
