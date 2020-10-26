using Core.DataAccess;
using entities.MasterTable;

using Entities.Concrate.MasterTable;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Abstract.MasterDB_DalAbstarct
{
    public  interface IUsersDal : IEntityRepository<Users>
    {
        List<UserClaims> GetRol(Users user);
    }

    
}
