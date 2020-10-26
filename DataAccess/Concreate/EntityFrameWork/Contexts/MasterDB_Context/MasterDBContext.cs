using entities.MasterTable;
using Entities.Concrate.MasterTable;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Concreate.EntityFrameWork.Contexts.MasterDB_Context
{
    public class MasterDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString: @"server = localhost; user = root; password = welat.123; database = MasterDB;");
        }
        public DbSet<Databases> databases { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<UserClaims> userClaims { get; set; }
        public DbSet<UserOperationClaims> userOperationClaims { get; set; }

    }
}
