using entities.MasterTable;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concreate.EntityFrameWork.Contexts.MasterDB_Context
{
   public class MasterDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString: @"server = localhost; user = root; password = welat123; database = MasterDB;");
        }
        public DbSet<Databases> databases { get; set; }
        public DbSet<Users> users { get; set; }
        
    }
}
