using Core.Entities.ConCreate;
using entities.MasterTable;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasKey(p => p.Id);
            modelBuilder.Entity<UserClaims>().HasKey(p => p.Id);
            modelBuilder.Entity<UserOperationClaims>().HasKey(p => p.Id);
            modelBuilder.Entity<Databases>().HasKey(p => p.Id);

            modelBuilder.Entity<UserOperationClaims>().HasOne<Users>().WithMany().HasForeignKey(p => p.UserRefId);
            modelBuilder.Entity<UserOperationClaims>().HasOne<UserClaims>().WithMany().HasForeignKey(p => p.UserClaimRefId);
            modelBuilder.Entity<Databases>().HasOne<Users>().WithMany().HasForeignKey(p => p.UsersRefId);





        }


    }
}
