using Core.Utilitis.Result;
using entities.MasterTable;
using System.Linq;

namespace Business.Abstract.MasterBusiness
{
    public interface IDatabasesManager
    {
        IDataResult<Databases> GetById(int id);
        IDataResult<IQueryable<Databases>> GetByUsers(int userId);
        IDataResult<IQueryable<Databases>> GetAll();
        IResult Update(Databases entity);
        IResult Add(Databases entity);
        IResult Delete(Databases entity);
        IResult CheckDatabasExist(string dataBaseName);

    }
}
