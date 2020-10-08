using Core.DataAccess;
using entities.MasterTable;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract.MasterDB_DalAbstarct
{
    public interface IDatabasesDal : IEntityRepository<Databases>
    {
       
    }
}
