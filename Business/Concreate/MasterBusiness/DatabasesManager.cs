using Business.Abstract.MasterBusiness;
using Business.Contents;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.AutoFac.Validation;
using Core.Utilitis.Result;
using DataAccess.Abstract.MasterDB_DalAbstarct;
using entities.MasterTable;
using System;
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
        [ValidationAspect(typeof(DatabasesValidator), Priority = 1)]
        public IResult Add(Databases entity)
        {
            var checkName = CheckDatabasExist(entity.DatabaseName);
            if (checkName.success)
                return new ErrorResult(Message: checkName.message);
            entity.RecordTime = DateTime.Now;
            entity.UpdateTime = DateTime.Now;
            _dabasesDal.Add(entity);
            return new SuccessResult(Message:ResultMessages.RecordSuccess);
        }

        public IResult CheckDatabasExist(string dataBaseName)
        {
            var check = _dabasesDal.Get(filter: x => x.DatabaseName == dataBaseName);
            if (check == null)
                return new ErrorResult(Message: "Database name not Exists");
            return new SuccessResult("Database name  Exists");
        }

        public IResult Delete(Databases entity)
        {
            _dabasesDal.Delete(entity);
            return new SuccessResult(Message:ResultMessages.DeleteSuccess);
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
        [ValidationAspect(typeof(DatabasesValidator), Priority = 1)]
        public IResult Update(Databases entity)
        {
            _dabasesDal.Update(entity);
            return new SuccessResult(Message:ResultMessages.UpdateSuccess);
        }
    }
}
