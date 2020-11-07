using Core.DataAccess.Entity;
using Core.Entities.ConCreate;
using DataAccess.Abstract.MasterDB_DalAbstarct;
using DataAccess.Concreate.EntityFrameWork.Contexts.MasterDB_Context;

namespace DataAccess.Concreate.EntityFrameWork.MasterDBDal
{
    public class UserClaimDal:BaseEF_EntityRepository<UserClaims,MasterDBContext>,IUserClaimDal
    {
        public UserClaimDal(MasterDBContext dBContext) : base(dBContext)
        {

        }
    }
}
