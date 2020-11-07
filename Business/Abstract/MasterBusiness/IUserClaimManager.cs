using Core.Entities.ConCreate;
using Core.Utilitis.Result;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract.MasterBusiness
{
    interface IUserClaimManager
    {
        IResult Add(UserClaims userClaim);
       
    }
}
