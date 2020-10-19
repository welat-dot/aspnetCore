using Core.Utilitis.Result;
using entities.MasterTable;
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
    }
}
