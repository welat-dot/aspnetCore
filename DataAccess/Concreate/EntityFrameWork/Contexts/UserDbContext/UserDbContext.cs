using Core.Entities.ConCreate;
using Entities.Concrate.UserDb_Table;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concreate.EntityFrameWork.Contexts.UserDbContext
{
    public class UserDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString: @"server = localhost; user = root; password = welat.123; database = Deneme;");
        }
        public DbSet<Adress> adresses { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<ProductPeerUnit> productPeerUnits { get; set; }
        public DbSet<ProductPriceUnit> productPriceUnits { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<UsersDetail> usersDetails { get; set; }
        public DbSet<UserClaims> userClaims { get; set; }
        public DbSet<UsersAdress> usersAdresses { get; set; }
        public DbSet<UserOperationClaims> userOperationClaims { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Basket>  baskets { get; set; }
        public DbSet<Orders> orders { get; set; }
        public DbSet<Sales>  sales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adress>().HasKey(p => p.Id);
            modelBuilder.Entity<Category>().HasKey(p => p.Id);
            modelBuilder.Entity<ProductPeerUnit>().HasKey(p => p.Id);
            modelBuilder.Entity<ProductPriceUnit>().HasKey(p => p.Id);
            modelBuilder.Entity<Users>().HasKey(p => p.Id);
            modelBuilder.Entity<UsersDetail>().HasKey(p => p.Id);
            modelBuilder.Entity<UserClaims>().HasKey(p => p.Id);
            modelBuilder.Entity<UsersAdress>().HasKey(p => p.Id);
            modelBuilder.Entity<UserOperationClaims>().HasKey(p => p.Id);
            modelBuilder.Entity<Product>().HasKey(p => p.Id);
            modelBuilder.Entity<Basket>().HasKey(p => p.Id);
            modelBuilder.Entity<Orders>().HasKey(p => p.Id);
            modelBuilder.Entity<Sales>().HasKey(p => p.Id);



            modelBuilder.Entity<UserOperationClaims>().HasOne<Users>().WithMany().HasForeignKey(p => p.UserRefId);
            modelBuilder.Entity<UserOperationClaims>().HasOne<UserClaims>().WithMany().HasForeignKey(p => p.UserClaimRefId);
            modelBuilder.Entity<Basket>().HasOne<Users>().WithMany().HasForeignKey(p => p.CustomerId);
            modelBuilder.Entity<Orders>().HasOne<Users>().WithMany().HasForeignKey(p => p.CustomerId);
            modelBuilder.Entity<Orders>().HasOne<Users>().WithMany().HasForeignKey(p => p.OwnerId);
            modelBuilder.Entity<Orders>().HasOne<Basket>().WithMany().HasForeignKey(p => p.BasketId);
            modelBuilder.Entity<Orders>().HasOne<Product>().WithMany().HasForeignKey(p => p.ProductId);
            modelBuilder.Entity<ProductPriceUnit>().HasOne<Product>().WithOne().HasForeignKey<Product>(p => p.PriceUnitId);
            modelBuilder.Entity<ProductPeerUnit>().HasOne<Product>().WithOne().HasForeignKey<Product>(p => p.PeerUnitId);
            modelBuilder.Entity<Users>().HasOne<Product>().WithOne().HasForeignKey<Product>(p => p.OwnerId);
            modelBuilder.Entity<Category>().HasOne<Product>().WithOne().HasForeignKey<Product>(p => p.CategoryId);

            modelBuilder.Entity<Orders>().HasOne<Sales>().WithOne().HasForeignKey<Sales>(p => p.OrdersId);
            modelBuilder.Entity<Sales>().HasOne<Users>().WithMany().HasForeignKey(p => p.OwnerId);
            modelBuilder.Entity<Sales>().HasOne<Users>().WithMany().HasForeignKey(p => p.CustomerId);
            modelBuilder.Entity<UsersAdress>().HasOne<Users>().WithMany().HasForeignKey(p => p.UserId);
            modelBuilder.Entity<Users>().HasOne<UsersDetail>().WithOne().HasForeignKey<UsersDetail>(p => p.UserId);



        }


    }
}
