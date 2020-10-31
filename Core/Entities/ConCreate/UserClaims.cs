using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Entities.ConCreate
{
    public class UserClaims: IEntity
    {
      
        public int Id { get; set; }
        [MaxLength(8)]
        public string Name { get; set; }
    }
}
