using Core.Entities;
using System;

namespace Entities.Concrate.UserDb_Table
{
    public class Orders:IEntity
    {
        public int Id { get; set; }
        public int BasketId { get; set; }
        public int ProductId { get; set; }
        public int OwnerId { get; set; }
        public int CustomerId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public bool? Confirmation { get; set; }
        public DateTime OrderTime { get; set; }
    }
}
