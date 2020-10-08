using Core.DataAccess;
using entities.MasterTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract.MasterDB_DalAbstarct
{
    public interface IUsersDal:IEntityRepository<Users>
    {
    }
}
