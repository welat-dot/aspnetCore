using Core.Entities;

namespace Entities.Concrate.UserDb_Table
{
    public class Basket:IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public double Price { get; set; }
    }
}
