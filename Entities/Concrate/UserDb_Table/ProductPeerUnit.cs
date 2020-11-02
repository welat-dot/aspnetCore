using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrate.UserDb_Table
{
    public class ProductPeerUnit:IEntity
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public int Quantity { get; set; }
        [MaxLength(15)]
        public string Unit { get; set; }
    }
}
