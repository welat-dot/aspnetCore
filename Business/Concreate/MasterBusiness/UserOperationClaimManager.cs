using Business.Abstract.MasterBusiness;
using Core.Entities.ConCreate;
using Core.Utilitis.Result;
using DataAccess.Abstract.MasterDB_DalAbstarct;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concreate.MasterBusiness
{
    public class UserOperationClaimManager : IUserOperationClaimManager
    {
        private IUserOperationClaimDal userOperationClaimDal;
        public UserOperationClaimManager(IUserOperationClaimDal userOperationClaimDal)
        {
            this.userOperationClaimDal = userOperationClaimDal;
        }
        public IResult Add(UserOperationClaims userOperationClaims)
        {
            userOperationClaimDal.Add(userOperationClaims);
            return new SuccessResult();
        }
    }
}
