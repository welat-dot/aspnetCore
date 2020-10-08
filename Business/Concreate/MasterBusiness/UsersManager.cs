using Business.Abstract.MasterBusiness;
using DataAccess.Abstract.MasterDB_DalAbstarct;
using DataAccess.Concreate.EntityFrameWork.Contexts.MasterDB_Context;
using entities.MasterTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Business.Concreate.MasterBusiness
{
    public class UsersManager : IUsersManager
    {
        private IUsersDal _usersDal;
        public UsersManager(IUsersDal usersDal)
        {
            _usersDal = usersDal;


        }
            
        public IQueryable<Users> GetAll()
        {
            return _usersDal.GetList();
        }

        public Users GetById(int id)
        {
            return _usersDal.Get(filter:x => x.Id == id);
        }
    }
}
