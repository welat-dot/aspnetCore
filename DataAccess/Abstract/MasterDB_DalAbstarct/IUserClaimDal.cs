using Core.DataAccess;
using Core.Entities.ConCreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract.MasterDB_DalAbstarct
{
    public interface IUserClaimDal : IEntityRepository<UserClaims>
    {
    }
}
