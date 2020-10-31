using Core.DataAccess;
using Core.Entities.ConCreate;
using entities.MasterTable;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Abstract.MasterDB_DalAbstarct
{
    public  interface IUsersDal : IEntityRepository<Users>
    {
        List<UserClaims> GetRol(Users user);
    }

    
}
