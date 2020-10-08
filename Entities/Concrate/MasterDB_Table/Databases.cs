using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace entities.MasterTable
{
   public class Databases:IEntity
    {
        public int Id { get; set; }
        public string DatabaseName { get; set; }        
        public int UsersRefId { get; set; }
       

    }
}
