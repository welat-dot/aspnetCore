using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrate.UserDb_Table
{
    public class Category:IEntity
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public int ParentId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
