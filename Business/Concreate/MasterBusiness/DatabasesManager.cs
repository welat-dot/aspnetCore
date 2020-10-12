using Business.Abstract.MasterBusiness;
using Core.Utilitis.Result;
using DataAccess.Abstract.MasterDB_DalAbstarct;
using entities.MasterTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace Business.Concreate.MasterBusiness
{
    public class DatabasesManager : IDatabasesManager
    {
        private IDatabasesDal _dabasesDal;
        public DatabasesManager(IDatabasesDal databasesDal)
        {
            _dabasesDal = databasesDal;
        }
        public IDataResult<IQueryable<Databases>> GetAll()
        {
            return new SuccessDataResult<IQueryable<Databases>>(_dabasesDal.GetList());
            
        }

        public IDataResult<Databases> GetById(int id)
        {
            return new SuccessDataResult<Databases>(_dabasesDal.Get(filter: x => x.Id == id));
          
        }

        public IDataResult<IQueryable<Databases>> GetByUsers(int userId)
        {
            return new SuccessDataResult<IQueryable<Databases>>(_dabasesDal.GetList(filter: x => x.UsersRefId == userId));
            
        }

       
    }
}
