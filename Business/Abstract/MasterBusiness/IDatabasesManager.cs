using Core.Utilitis.Result;
using DataAccess.Abstract.MasterDB_DalAbstarct;
using entities.MasterTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Abstract.MasterBusiness
{
    public interface IDatabasesManager
    {
        IDataResult<Databases> GetById(int id);
        IDataResult<IQueryable<Databases>> GetByUsers(int userId);
        IDataResult<IQueryable<Databases>> GetAll();

    }
}
