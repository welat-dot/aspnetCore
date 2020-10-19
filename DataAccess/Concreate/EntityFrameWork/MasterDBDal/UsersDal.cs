using Core.DataAccess.Entity;
using DataAccess.Abstract.MasterDB_DalAbstarct;
using DataAccess.Concreate.EntityFrameWork.Contexts.MasterDB_Context;
using entities.MasterTable;

namespace DataAccess.Concreate.EntityFrameWork.MasterDBDal
{
    public class UsersDal : BaseEF_EntityRepository<Users, MasterDBContext>, IUsersDal
    {

    }
}
