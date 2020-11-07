
using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Abstract.MasterBusiness;
using Business.Concreate;
using Business.Concreate.MasterBusiness;
using Castle.DynamicProxy;
using Core.Utilitis.InterCeptors;
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
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector=new AspectInterCeptorSelector()
                }).SingleInstance();

        }
    }
}