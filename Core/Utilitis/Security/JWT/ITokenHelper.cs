using Core.Entities.ConCreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilitis.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(Users user,List<UserClaims> claims,string DatabaseName);
    }
}
