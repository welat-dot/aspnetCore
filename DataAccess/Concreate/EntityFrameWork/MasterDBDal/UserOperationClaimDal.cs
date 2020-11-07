using Core.DataAccess.Entity;
using Core.Entities.ConCreate;
using DataAccess.Abstract.MasterDB_DalAbstarct;
using DataAccess.Concreate.EntityFrameWork.Contexts.MasterDB_Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concreate.EntityFrameWork.MasterDBDal
{
    public class UserOperationClaimDal:BaseEF_EntityRepository<UserOperationClaims,MasterDBContext>,IUserOperationClaimDal
    {
        public UserOperationClaimDal(MasterDBContext dBContext) : base(dBContext)
        {

        }
    }
}
