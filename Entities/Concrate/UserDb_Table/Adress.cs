using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrate.UserDb_Table
{
    public class Adress:IEntity
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public int ParentId { get; set; }

    }
}
