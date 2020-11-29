using Business.Abstract;
using Business.Abstract.MasterBusiness;
using Business.Contents;
using Core.Entities.ConCreate;
using Core.Utilitis.Result;
using Core.Utilitis.Security.Hashing;
using Core.Utilitis.Security.JWT;
using Entities.DTO;

namespace Business.Concreate
{
    public class AuthManager : IAuthService
    {
        private IUsersManager usersManager;
        private ITokenHelper tokenHelper;
        private IUserOperationClaimManager userOperationClaimManager;

        public AuthManager(IUsersManager usersManager, ITokenHelper tokenHelper,IUserOperationClaimManager userOperationClaimManager)
        {
            this.usersManager = usersManager;
            this.tokenHelper = tokenHelper;
            this.userOperationClaimManager = userOperationClaimManager;
        }
        //Master Create Token
        public IDataResult<AccessToken> CreateAccessToken(Users users,string databaseName)
        {
            var claim = usersManager.GetClaims(user: users).data;
            var token = tokenHelper.CreateToken(user: users, claims: claim,databaseName);
            return new SuccessDataResult<AccessToken>(token, ResultMessages.AccessTokenCreated);
        }
        //Master Login
        public IDataResult<Users> Login(ForLoginDto forLoginDto)
        {
           var CheckLogin = userEmaiOrNameExist(forLoginDto.UserName);
           if(CheckLogin.success==false)
            {
                return new ErrorDataResult<Users>(Message: "Kullanıcı Bulunamadı");
            }
            if (!HashingHelper.VerifityPasswordHash(forLoginDto.Password, CheckLogin.data.UserPasswordHash, CheckLogin.data.UserPasswordSalt))
            {
                return new ErrorDataResult<Users>(ResultMessages.ErrorPassword);
            }
            forLoginDto.DataBaseName = "MasterUser";
            return new SuccessDataResult<Users>(CheckLogin.data, ResultMessages.SuccessLogin);
        }
        //Register
        public IResult Register(ForRegisterDTO forRegisterDTO, string password)
        {
            if(!userMailExist(forRegisterDTO.Email).success)
            {
                if (userUserNameExist(forRegisterDTO.UserName).success)
                    return new ErrorResult(Message: "Kullanıcı Adı tekrarlı");
            }
            else
            {
                return new ErrorResult(Message:"Mail tekrarlı");
            }
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreateHash(forRegisterDTO.Password,out passwordHash, out passwordSalt);
       

            var user = new Users { 
            EmailAdress=forRegisterDTO.Email,
            UserName=forRegisterDTO.UserName,
            FirstName=forRegisterDTO.FirstName,
            LastName=forRegisterDTO.LastName,
            Status=true,
            UserPasswordHash=passwordHash,
            UserPasswordSalt=passwordSalt            
            };
           Users users  = usersManager.Add(user).data;
          userOperationClaimManager.AddForRegister(users.Id);

           
           
            return new SuccessResult(Message: ResultMessages.Registered+"for  UserName= "+user.UserName);
        }
        //Master Exits Controll
        public IDataResult<Users> userEmaiOrNameExist(string emailOrName)
        {
            var mailCheck = userMailExist(emailOrName);
            var nameCheck = userUserNameExist(emailOrName);
            if(mailCheck.success==true)
            {
                return new SuccessDataResult<Users>((Users)mailCheck.data);
            }
            if(nameCheck.success==true)
            {
                return new SuccessDataResult<Users>((Users)nameCheck.data);
            }
            return new ErrorDataResult<Users>("Kullanıcı Bulunamadı");
        }
        public IDataResult<Users> userMailExist(string email)
        {
           Users userCheck = usersManager.GetByMail(email).data;
           if(userCheck==null)
            {
                return new ErrorDataResult<Users>(Message:"Kullanici Bulunamadi");
            }
            return new SuccessDataResult<Users>(userCheck);
        }
        public IDataResult<Users> userUserNameExist(string username)
        {
            Users userCheck = usersManager.GetByUserName(username).data;
            if (userCheck== null)
            {
                return new ErrorDataResult<Users>(Message: "Kullanıcı Bulunamadı");
            }
            return new SuccessDataResult<Users>(userCheck);
        }
    }
}
