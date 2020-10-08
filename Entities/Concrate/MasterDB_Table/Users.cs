using Core.Entities;
using System;
using System.Collections.Generic;

using System.Text;

namespace entities.MasterTable
{
    public class Users:IEntity
    {
        public int Id { get; set; }         
        public string UserName { get; set; }       
        public string UserPassword { get; set; }

    }
}
