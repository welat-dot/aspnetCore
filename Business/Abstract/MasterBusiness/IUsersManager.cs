using entities.MasterTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Abstract.MasterBusiness
{
    public interface IUsersManager
    {
        IQueryable<Users> GetAll();
        Users GetById(int id);
    }
}
