using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrate.UserDb_Table
{
    public class ProductPriceUnit:IEntity
    {
        public int Id { get; set; }
        [MaxLength(15)]
        public string Name { get; set; }
    }
}
