﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SHoper.Data;

#nullable disable

namespace SHoper.Migrations.ApplicationDbMyDataMigrations
{
    [DbContext(typeof(ApplicationDbMyData))]
    partial class ApplicationDbMyDataModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SHoper.Model.Basket", b =>
                {
                    b.Property<int>("BasketID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BasketID"));

                    b.Property<int?>("UserAsClientId")
                        .HasColumnType("int");

                    b.HasKey("BasketID");

                    b.HasIndex("UserAsClientId")
                        .IsUnique()
                        .HasFilter("[UserAsClientId] IS NOT NULL");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("SHoper.Model.Items", b =>
                {
                    b.Property<int>("ItemsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemsID"));

                    b.Property<int?>("BasketId")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ItemPrice")
                        .HasColumnType("float");

                    b.HasKey("ItemsID");

                    b.HasIndex("BasketId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("SHoper.Model.UserAsClient", b =>
                {
                    b.Property<int>("UserAsClientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserAsClientID"));

                    b.Property<string>("UsernameInForum")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserAsClientID");

                    b.ToTable("UserAsClients");
                });

            modelBuilder.Entity("SHoper.Model.Basket", b =>
                {
                    b.HasOne("SHoper.Model.UserAsClient", "UserAsClient")
                        .WithOne("Basket")
                        .HasForeignKey("SHoper.Model.Basket", "UserAsClientId");

                    b.Navigation("UserAsClient");
                });

            modelBuilder.Entity("SHoper.Model.Items", b =>
                {
                    b.HasOne("SHoper.Model.Basket", "Basket")
                        .WithMany("Item")
                        .HasForeignKey("BasketId");

                    b.Navigation("Basket");
                });

            modelBuilder.Entity("SHoper.Model.Basket", b =>
                {
                    b.Navigation("Item");
                });

            modelBuilder.Entity("SHoper.Model.UserAsClient", b =>
                {
                    b.Navigation("Basket");
                });
#pragma warning restore 612, 618
        }
    }
}
