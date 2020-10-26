using Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entities.MasterTable
{
    public class Databases : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string DatabaseName { get; set; }
        public Users User { get; set; }
        [ForeignKey(nameof(Users))]
        public int UsersRefId { get; set; }


    }
}
