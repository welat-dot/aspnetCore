using Core.Entities;
using entities.MasterTable;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;
using System.Text;

namespace Entities.Concrate.MasterTable
{
    public class UserOperationClaims: IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Users users { get; set; }       
        public UserClaims userClaims { get; set; }



        [ForeignKey(nameof(UserClaims))]
        public int UserClaimRefId { get; set; }
        [ForeignKey(nameof(Users))]
        public int UserRefId { get; set; }
    }
}
