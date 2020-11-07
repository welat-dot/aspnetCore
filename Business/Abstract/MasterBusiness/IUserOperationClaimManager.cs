using Core.Entities.ConCreate;
using Core.Utilitis.Result;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract.MasterBusiness
{
    public interface IUserOperationClaimManager
    {
        IResult Add(UserOperationClaims userOperationClaims);
    }
}
