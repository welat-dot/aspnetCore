using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;
using System.Text;

namespace Core.Entities.ConCreate
{
    public class UserOperationClaims: IEntity
    {
       
        public int Id { get; set; }
        public int UserClaimRefId { get; set; }
        public int UserRefId { get; set; }
    }
}
