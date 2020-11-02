using Business.Abstract.MasterBusiness;
using Business.Contents;
using Core.Entities.ConCreate;
using Core.Utilitis.Result;
using DataAccess.Abstract.MasterDB_DalAbstarct;
using System.Collections.Generic;
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
            return new SuccessResult(Message: ResultMessages.RecordSuccess);
        }

        public IResult Delete(Users entity)
        {
            _usersDal.Delete(entity);
            return new SuccessResult(Message:ResultMessages.DeleteSuccess);
        }

        public IDataResult<IQueryable<Users>> GetAll()
        {
            return new SuccessDataResult<IQueryable<Users>>(_usersDal.GetList());
        }

        public IDataResult<Users> GetById(int id)
        {
            return new SuccessDataResult<Users>(_usersDal.Get(filter: x => x.Id == id));
        }

        public IDataResult<Users> GetByMail(string email)
        {
            return new SuccessDataResult<Users>(_usersDal.Get(filter: x => x.EmailAdress == email));
        }

        public IDataResult<Users> GetByUserName(string userName)
        {
            return new SuccessDataResult<Users>(_usersDal.Get(filter: x => x.UserName == userName));
        }

        public IDataResult< List<UserClaims>> GetClaims(Users user)
        {
            return new SuccessDataResult<List<UserClaims>>(_usersDal.GetRol(user));
        }

        public IResult Update(Users entity)
        {
            _usersDal.Update(entity);
            return new SuccessResult(Message:ResultMessages.UpdateSuccess);
        }
    }
}
