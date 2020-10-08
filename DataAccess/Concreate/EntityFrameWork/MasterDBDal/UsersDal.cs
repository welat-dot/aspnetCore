using Core.DataAccess.Entity;
using DataAccess.Abstract.MasterDB_DalAbstarct;
using DataAccess.Concreate.EntityFrameWork.Contexts.MasterDB_Context;
using entities.MasterTable;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace DataAccess.Concreate.EntityFrameWork.MasterDBDal
{
    public class UsersDal:BaseEF_EntityRepository<Users,MasterDBContext>,IUsersDal
    {

    }
}
