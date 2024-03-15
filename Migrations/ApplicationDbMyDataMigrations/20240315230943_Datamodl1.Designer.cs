﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SHoper.Data;

#nullable disable

namespace SHoper.Migrations.ApplicationDbMyDataMigrations
{
    [DbContext(typeof(ApplicationDbMyData))]
    [Migration("20240315230943_Datamodl1")]
    partial class Datamodl1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SHoper.Model.Items", b =>
                {
                    b.Property<int>("ItemsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemsID"));

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ItemPrice")
                        .HasColumnType("float");

                    b.Property<int?>("UserAsClientID")
                        .HasColumnType("int");

                    b.HasKey("ItemsID");

                    b.HasIndex("UserAsClientID");

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

                    b.ToTable("UserAsClient");
                });

            modelBuilder.Entity("SHoper.Model.Items", b =>
                {
                    b.HasOne("SHoper.Model.UserAsClient", "UserClient")
                        .WithMany("Items")
                        .HasForeignKey("UserAsClientID");

                    b.Navigation("UserClient");
                });

            modelBuilder.Entity("SHoper.Model.UserAsClient", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
