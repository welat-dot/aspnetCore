using Core.DataAccess.Entity;
using DataAccess.Abstract.MasterDB_DalAbstarct;
using DataAccess.Concreate.EntityFrameWork.Contexts.MasterDB_Context;
using entities.MasterTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concreate.EntityFrameWork.MasterDBDal
{
    class DatabasesDal : BaseEF_EntityRepository<Databases,MasterDBContext>, IDatabasesDal
    {
    }

   
}
