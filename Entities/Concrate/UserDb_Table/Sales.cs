using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate.UserDb_Table
{
    public class Sales:IEntity
    {
        public int Id { get; set; }
        public int OrdersId { get; set; }
        public int OwnerId { get; set; }
        public int CustomerId { get; set; }
        public double Price { get; set; }
        public bool? CustomerConfirmation { get; set; }
        public DateTime SalesTime { get; set; }
    }
}
