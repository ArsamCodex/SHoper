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
                .HasAnnotation("ProductVersion", "7.0.17")
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

            modelBuilder.Entity("SHoper.Model.Emplyee.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("SHoper.Model.Emplyee.EmployeeTask", b =>
                {
                    b.Property<int>("EmployeeTaskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeTaskID"));

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TaskName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YourText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeTaskID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Task");
                });

            modelBuilder.Entity("SHoper.Model.Emplyee.Vacation", b =>
                {
                    b.Property<int>("VacationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VacationID"));

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.Property<string>("VacationText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VacationID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Vacation");
                });

            modelBuilder.Entity("SHoper.Model.IncomingNumber", b =>
                {
                    b.Property<int>("IncomingNumberID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IncomingNumberID"));

                    b.Property<DateTime>("DateTimeIn")
                        .HasColumnType("datetime2");

                    b.Property<int>("IncomingNumberT")
                        .HasColumnType("int");

                    b.HasKey("IncomingNumberID");

                    b.ToTable("IncomingNumber");
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

            modelBuilder.Entity("SHoper.Model.Emplyee.EmployeeTask", b =>
                {
                    b.HasOne("SHoper.Model.Emplyee.Employee", "Employees")
                        .WithMany("Tasks")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("SHoper.Model.Emplyee.Vacation", b =>
                {
                    b.HasOne("SHoper.Model.Emplyee.Employee", "Employees")
                        .WithMany("Vacations")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");
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

            modelBuilder.Entity("SHoper.Model.Emplyee.Employee", b =>
                {
                    b.Navigation("Tasks");

                    b.Navigation("Vacations");
                });

            modelBuilder.Entity("SHoper.Model.UserAsClient", b =>
                {
                    b.Navigation("Basket");
                });
#pragma warning restore 612, 618
        }
    }
}
