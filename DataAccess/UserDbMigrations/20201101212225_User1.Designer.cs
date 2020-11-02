﻿// <auto-generated />
using System;
using DataAccess.Concreate.EntityFrameWork.Contexts.UserDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.UserDbMigrations
{
    [DbContext(typeof(UserDbContext))]
    [Migration("20201101212225_User1")]
    partial class User1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Entities.ConCreate.UserClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(8) CHARACTER SET utf8mb4")
                        .HasMaxLength(8);

                    b.HasKey("Id");

                    b.ToTable("userClaims");
                });

            modelBuilder.Entity("Core.Entities.ConCreate.UserOperationClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("UserClaimRefId")
                        .HasColumnType("int");

                    b.Property<int>("UserRefId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserClaimRefId");

                    b.HasIndex("UserRefId");

                    b.ToTable("userOperationClaims");
                });

            modelBuilder.Entity("Core.Entities.ConCreate.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("EmailAdress")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(8) CHARACTER SET utf8mb4")
                        .HasMaxLength(8);

                    b.Property<byte[]>("UserPasswordHash")
                        .HasColumnType("varbinary(500)")
                        .HasMaxLength(500);

                    b.Property<byte[]>("UserPasswordSalt")
                        .HasColumnType("varbinary(500)")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Entities.Concrate.UserDb_Table.Adress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("adresses");
                });

            modelBuilder.Entity("Entities.Concrate.UserDb_Table.Basket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("baskets");
                });

            modelBuilder.Entity("Entities.Concrate.UserDb_Table.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("Entities.Concrate.UserDb_Table.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BasketId")
                        .HasColumnType("int");

                    b.Property<bool?>("Confirmation")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BasketId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OwnerId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("Entities.Concrate.UserDb_Table.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("PeerUnitId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<int>("PriceUnitId")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId")
                        .IsUnique();

                    b.HasIndex("OwnerId")
                        .IsUnique();

                    b.HasIndex("PeerUnitId")
                        .IsUnique();

                    b.HasIndex("PriceUnitId")
                        .IsUnique();

                    b.ToTable("products");
                });

            modelBuilder.Entity("Entities.Concrate.UserDb_Table.ProductPeerUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("productPeerUnits");
                });

            modelBuilder.Entity("Entities.Concrate.UserDb_Table.ProductPriceUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("productPriceUnits");
                });

            modelBuilder.Entity("Entities.Concrate.UserDb_Table.Sales", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool?>("CustomerConfirmation")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("OrdersId")
                        .HasColumnType("int");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("SalesTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OrdersId")
                        .IsUnique();

                    b.HasIndex("OwnerId");

                    b.ToTable("sales");
                });

            modelBuilder.Entity("Entities.Concrate.UserDb_Table.UsersAdress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Adress")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AdressDescription")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("usersAdresses");
                });

            modelBuilder.Entity("Entities.Concrate.UserDb_Table.UsersDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("IBAN")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TelNo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("usersDetails");
                });

            modelBuilder.Entity("Core.Entities.ConCreate.UserOperationClaims", b =>
                {
                    b.HasOne("Core.Entities.ConCreate.UserClaims", null)
                        .WithMany()
                        .HasForeignKey("UserClaimRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.ConCreate.Users", null)
                        .WithMany()
                        .HasForeignKey("UserRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrate.UserDb_Table.Basket", b =>
                {
                    b.HasOne("Core.Entities.ConCreate.Users", null)
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrate.UserDb_Table.Orders", b =>
                {
                    b.HasOne("Entities.Concrate.UserDb_Table.Basket", null)
                        .WithMany()
                        .HasForeignKey("BasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.ConCreate.Users", null)
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.ConCreate.Users", null)
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrate.UserDb_Table.Product", b =>
                {
                    b.HasOne("Entities.Concrate.UserDb_Table.Category", null)
                        .WithOne()
                        .HasForeignKey("Entities.Concrate.UserDb_Table.Product", "CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.ConCreate.Users", null)
                        .WithOne()
                        .HasForeignKey("Entities.Concrate.UserDb_Table.Product", "OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrate.UserDb_Table.ProductPeerUnit", null)
                        .WithOne()
                        .HasForeignKey("Entities.Concrate.UserDb_Table.Product", "PeerUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrate.UserDb_Table.ProductPriceUnit", null)
                        .WithOne()
                        .HasForeignKey("Entities.Concrate.UserDb_Table.Product", "PriceUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrate.UserDb_Table.Sales", b =>
                {
                    b.HasOne("Core.Entities.ConCreate.Users", null)
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrate.UserDb_Table.Orders", null)
                        .WithOne()
                        .HasForeignKey("Entities.Concrate.UserDb_Table.Sales", "OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.ConCreate.Users", null)
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrate.UserDb_Table.UsersAdress", b =>
                {
                    b.HasOne("Core.Entities.ConCreate.Users", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrate.UserDb_Table.UsersDetail", b =>
                {
                    b.HasOne("Core.Entities.ConCreate.Users", null)
                        .WithOne()
                        .HasForeignKey("Entities.Concrate.UserDb_Table.UsersDetail", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
