
using Autofac;
using Business.Abstract;
using Business.Abstract.MasterBusiness;
using Business.Concreate;
using Business.Concreate.MasterBusiness;
using Core.Utilitis.Security.JWT;
using DataAccess.Abstract.MasterDB_DalAbstarct;
using DataAccess.Concreate.EntityFrameWork.MasterDBDal;
namespace Business.DepencyResolver
{
    public class AutofacDepencyModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DatabasesManager>().As<IDatabasesManager>();
            builder.RegisterType<UsersManager>().As<IUsersManager>();
            builder.RegisterType<DatabasesDal>().As<IDatabasesDal>();
            builder.RegisterType<UsersDal>().As<IUsersDal>();
            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();


        }
    }
}