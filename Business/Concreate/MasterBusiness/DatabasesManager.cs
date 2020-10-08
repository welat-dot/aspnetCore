using Business.Abstract.MasterBusiness;
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
        public IQueryable<Databases> GetAll()
        {
            return _dabasesDal.GetList();
        }

        public Databases GetById(int id)
        {
            return _dabasesDal.Get(filter: x => x.Id == id);
        }

        public IQueryable<Databases> GetByUsers(int userId)
        {
            return _dabasesDal.GetList(filter: x => x.UsersRefId == userId);
        }

       
    }
}
