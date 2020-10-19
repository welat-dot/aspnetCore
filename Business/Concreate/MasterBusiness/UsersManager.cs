using Business.Abstract.MasterBusiness;
using Core.Utilitis.Result;
using DataAccess.Abstract.MasterDB_DalAbstarct;
using entities.MasterTable;
using System.Linq;

namespace Business.Concreate.MasterBusiness
{
    public class UsersManager : IUsersManager
    {
        private IUsersDal _usersDal;
        public UsersManager(IUsersDal usersDal)
        {
            _usersDal = usersDal;


        }

        public IResult Add(Users entity)
        {
            _usersDal.Add(entity);
            return new SuccessResult(Message: "Kayit İşlemi başarılı");
        }

        public IResult Delete(Users entity)
        {
            _usersDal.Delete(entity);
            return new SuccessResult(Message: "Silme İşlemi başarılı");
        }

        public IDataResult<IQueryable<Users>> GetAll()
        {
            return new SuccessDataResult<IQueryable<Users>>(_usersDal.GetList());
        }

        public IDataResult<Users> GetById(int id)
        {
            return new SuccessDataResult<Users>(_usersDal.Get(filter: x => x.Id == id));
        }

        public IResult Update(Users entity)
        {
            _usersDal.Update(entity);
            return new SuccessResult(Message: "Güncelleme İşlemi başarılı");
        }
    }
}
