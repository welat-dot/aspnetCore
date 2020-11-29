using Core.Entities.ConCreate;
using Core.Utilitis.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Abstract.MasterBusiness
{
   public  interface IUserClaimManager
    {
        IResult Add(UserClaims userClaim);
        IDataResult<IQueryable<UserClaims>> GetUserClaim();
       
    }
}
