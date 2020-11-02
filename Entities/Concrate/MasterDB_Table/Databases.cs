using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entities.MasterTable
{
    public class Databases : IEntity
    { 
        public int Id { get; set; }
        [MaxLength(20)]
        public string DatabaseName { get; set; }
        public int UsersRefId { get; set; }
        public DateTime RecordTime { get; set; }
        public DateTime UpdateTime { get; set; }


    }
}
