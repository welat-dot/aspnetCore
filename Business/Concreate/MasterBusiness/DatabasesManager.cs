using Business.Abstract.MasterBusiness;
using Core.Utilitis.Result;
using DataAccess.Abstract.MasterDB_DalAbstarct;
using entities.MasterTable;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Concreate.MasterBusiness
{
    public class DatabasesManager : IDatabasesManager
    {
        private IDatabasesDal _dabasesDal;
        public DatabasesManager(IDatabasesDal databasesDal)
        {
            _dabasesDal = databasesDal;
        }

        public IResult Add(Databases entity)
        {
            _dabasesDal.Add(entity);
            return new SuccessResult(Message: "Eklem İşlemi Başarılı");
        }

        public IResult Delete(Databases entity)
        {
            _dabasesDal.Delete(entity);
            return new SuccessResult(Message: "silme işlemi Başarılı");
        }

        public IDataResult<IQueryable<Databases>> GetAll()
        {
            return  new SuccessDataResult<IQueryable<Databases>>( _dabasesDal.GetList());

        }

        public IDataResult<Databases> GetById(int id)
        {
            return new SuccessDataResult<Databases>(_dabasesDal.Get(filter: x => x.Id == id));

        }

        public IDataResult<IQueryable<Databases>> GetByUsers(int userId)
        {
            return new SuccessDataResult<IQueryable<Databases>>(_dabasesDal.GetList(filter: x => x.UsersRefId == userId));

        }

        public IResult Update(Databases entity)
        {
            _dabasesDal.Update(entity);

            return new SuccessResult(Message: "Güncelleme İşlemi Başarılı");
        }
    }
}
