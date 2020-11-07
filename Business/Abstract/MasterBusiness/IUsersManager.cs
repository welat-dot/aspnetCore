using Core.Entities.ConCreate;
using Core.Utilitis.Result;
using System.Collections.Generic;
using System.Linq;

namespace Business.Abstract.MasterBusiness
{
    public interface IUsersManager
    {
        IDataResult<IQueryable<Users>> GetAll();
        IDataResult<Users> GetById(int id);
        IResult Add(Users entity);
        IResult Delete(Users entity);
        IResult Update(Users entity);
        IDataResult< List<UserClaims>> GetClaims(Users user);
        IDataResult<Users> GetByMail(string email);
        IDataResult<Users> GetByUserName(string userName);
      

    }
}
