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
        Databases GetById(int id);
        IQueryable<Databases> GetByUsers(int userId);
        IQueryable<Databases> GetAll();

    }
}
