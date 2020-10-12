using Core.Utilitis.Result;
using entities.MasterTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Abstract.MasterBusiness
{
    public interface IUsersManager
    {
        IDataResult<IQueryable<Users>> GetAll();
        IDataResult<Users> GetById(int id);
    }
}
