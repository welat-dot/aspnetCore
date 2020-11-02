using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrate.UserDb_Table
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public double Price { get; set; }
        public int PriceUnitId { get; set; }
        public int PeerUnitId { get; set; }
        public int Stock { get; set; }
        public int OwnerId { get; set; }
        public int CategoryId { get; set; }
    }
}
