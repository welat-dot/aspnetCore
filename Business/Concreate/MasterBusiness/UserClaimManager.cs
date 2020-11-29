using Business.Abstract.MasterBusiness;
using Core.Entities.ConCreate;
using Core.Utilitis.Result;
using DataAccess.Abstract.MasterDB_DalAbstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concreate.MasterBusiness
{
    class UserClaimManager : IUserClaimManager
    {
        private IUserClaimDal  userClaimDal;
        public UserClaimManager(IUserClaimDal userClaimDal)
        {
            this.userClaimDal = userClaimDal;
        }
        public IResult Add(UserClaims userClaim)
        {
            userClaimDal.Add(userClaim);
            return new SuccessResult();
        }

        public IDataResult<IQueryable<UserClaims>> GetUserClaim()
        {
            IQueryable<UserClaims> claims = userClaimDal.GetList();
            return new SuccessDataResult<IQueryable<UserClaims>>(userClaimDal.GetList());              
            
        }
    }
}
