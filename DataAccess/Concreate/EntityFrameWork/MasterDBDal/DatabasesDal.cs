using Core.DataAccess.Entity;
using DataAccess.Abstract.MasterDB_DalAbstarct;
using DataAccess.Concreate.EntityFrameWork.Contexts.MasterDB_Context;
using entities.MasterTable;

namespace DataAccess.Concreate.EntityFrameWork.MasterDBDal
{
    public class DatabasesDal : BaseEF_EntityRepository<Databases, MasterDBContext>, IDatabasesDal
    {
    }


}
