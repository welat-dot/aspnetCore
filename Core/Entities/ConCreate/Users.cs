using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities.ConCreate
{
    public class Users : IEntity
    {
       
        public int Id { get; set; }
        [MaxLength(8)]
        public string UserName { get; set; }
        [MaxLength(500)]
        public byte[] UserPasswordSalt { get; set; }
        [MaxLength(500)]
        public byte[] UserPasswordHash { get; set; }
        public bool Status { get; set; } = false;

        [MaxLength(50)]
        public string EmailAdress  { get; set; }
        [MaxLength(50)]
        public string  FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
       
    }
}
