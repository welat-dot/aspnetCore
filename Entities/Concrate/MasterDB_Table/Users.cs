using Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entities.MasterTable
{
    public class Users : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(8)]
        public string UserName { get; set; }
        [MaxLength(8)]
        public string UserPassword { get; set; }
        public bool Status { get; set; } = false;

        [MaxLength(50)]
        public string EmailAdress  { get; set; }
        [MaxLength(50)]
        public string  FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
    }
}
