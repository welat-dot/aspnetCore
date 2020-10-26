using Core.DataAccess.Entity;
using DataAccess.Abstract.MasterDB_DalAbstarct;
using DataAccess.Concreate.EntityFrameWork.Contexts.MasterDB_Context;
using entities.MasterTable;
using Entities.Concrate.MasterTable;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concreate.EntityFrameWork.MasterDBDal
{
    public class UsersDal : BaseEF_EntityRepository<Users, MasterDBContext>, IUsersDal
    {
        private MasterDBContext dBContext; 
        public UsersDal(MasterDBContext dBContext):base(dBContext)
        {
            this.dBContext = dBContext;
        }

        public List<UserClaims> GetRol(Users user)
        {
            var result = from UserClaims in dBContext.userClaims
                         join UserOperationClaims in dBContext.userOperationClaims
                             on UserClaims.Id equals UserOperationClaims.UserClaimRefId
                         where UserOperationClaims.UserRefId == user.Id
                         select new UserClaims
                         {
                             Id = UserClaims.Id,
                             Name = UserClaims.Name
                         };
            return result.ToList();
        }

      
    }
}
