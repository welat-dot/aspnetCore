
using Autofac;
using Business.Abstract.MasterBusiness;
using Business.Concreate.MasterBusiness;
using DataAccess.Abstract.MasterDB_DalAbstarct;
using DataAccess.Concreate.EntityFrameWork.MasterDBDal;
namespace Business.DepencyResolver
{
    public class AutofacDepencyModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           builder.RegisterType<DatabasesManager>().As<IDatabasesManager>();
           builder.RegisterType<UsersManager>().As<IUsersManager>();
           builder.RegisterType<DatabasesDal>().As<IDatabasesDal>();
           builder.RegisterType<UsersDal>().As<IUsersDal>();
           

        } 
    }
}