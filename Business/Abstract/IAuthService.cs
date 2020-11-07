using Core.Entities.ConCreate;
using Core.Utilitis.Result;
using Core.Utilitis.Security.JWT;
using Entities.DTO;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IResult Register(ForRegisterDTO forRegisterDTO, string password);
        IDataResult<Users> Login(ForLoginDto forLoginDto);
        IDataResult<Users> userMailExist(string email);
        IDataResult<Users> userUserNameExist(string username);
        IDataResult<Users> userEmaiOrNameExist(string emailOrName);
        IDataResult<AccessToken> CreateAccessToken(Users users, string databaseName);

    }
}
