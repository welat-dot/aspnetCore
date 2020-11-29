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
    public class UserOperationClaimManager : IUserOperationClaimManager
    {
        private IUserOperationClaimDal userOperationClaimDal;
        private IUserClaimManager  userClaimManager;
        public UserOperationClaimManager(IUserOperationClaimDal userOperationClaimDal,IUserClaimManager userClaimManager)
        {
            this.userOperationClaimDal = userOperationClaimDal;
            this.userClaimManager = userClaimManager;
        }
        public IResult Add(UserOperationClaims userOperationClaims)
        {
            userOperationClaimDal.Add(userOperationClaims);
            return new SuccessResult();
        }

        public void AddForRegister(int userid)
        {
            IQueryable<UserClaims> claims = userClaimManager.GetUserClaim().data;
            List<UserOperationClaims> operationClaims = new List<UserOperationClaims>();

            foreach (UserClaims claims1 in claims)
            {
                UserOperationClaims userOperationClaims = new UserOperationClaims();
                userOperationClaims.UserClaimRefId = claims1.Id;
                userOperationClaims.UserRefId = userid;

                if (claims1.Name != "SystemAdministor")
                {
                    operationClaims.Add(userOperationClaims);
                }
            }

            userOperationClaimDal.AddRange(operationClaims);
        }
    }
}
