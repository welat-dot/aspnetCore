﻿// <auto-generated />
using System;
using DataAccess.Concreate.EntityFrameWork.Contexts.MasterDB_Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.MasterMigrations
{
    [DbContext(typeof(MasterDBContext))]
    [Migration("20201102012259_Master15")]
    partial class Master15
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
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

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

            modelBuilder.Entity("entities.MasterTable.Databases", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DatabaseName")
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.Property<DateTime>("RecordTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UsersRefId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsersRefId");

                    b.ToTable("databases");
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

            modelBuilder.Entity("entities.MasterTable.Databases", b =>
                {
                    b.HasOne("Core.Entities.ConCreate.Users", null)
                        .WithMany()
                        .HasForeignKey("UsersRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
