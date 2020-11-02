using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrate.UserDb_Table
{
    public class UsersAdress:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        [MaxLength(100)]
        public string Adress { get; set; }
        [MaxLength(100)]
        public string AdressDescription { get; set; }

    }
}
