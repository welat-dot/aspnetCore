using Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entities.MasterTable
{
    public class Databases : IEntity
    { 
        public int Id { get; set; }
        [MaxLength(50)]
        public string DatabaseName { get; set; }
        public int UsersRefId { get; set; }


    }
}
