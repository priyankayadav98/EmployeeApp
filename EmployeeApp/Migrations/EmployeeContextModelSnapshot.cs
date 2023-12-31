﻿// <auto-generated />
using EmployeeApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeApp.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    partial class EmployeeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeApp.Models.Designation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Designations");
                });

            modelBuilder.Entity("EmployeeApp.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DesignationId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaymentRuleId")
                        .HasColumnType("int");

                    b.Property<int>("WorkingHourId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DesignationId");

                    b.HasIndex("PaymentRuleId");

                    b.HasIndex("WorkingHourId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EmployeeApp.Models.PaymentRule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Rule")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PaymentRules");
                });

            modelBuilder.Entity("EmployeeApp.Models.WorkingHour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Hour")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WorkingHours");
                });

            modelBuilder.Entity("EmployeeApp.Models.Employee", b =>
                {
                    b.HasOne("EmployeeApp.Models.Designation", null)
                        .WithMany("Employee")
                        .HasForeignKey("DesignationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmployeeApp.Models.PaymentRule", null)
                        .WithMany("Employee")
                        .HasForeignKey("PaymentRuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmployeeApp.Models.WorkingHour", null)
                        .WithMany("Employee")
                        .HasForeignKey("WorkingHourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmployeeApp.Models.Designation", b =>
                {
                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EmployeeApp.Models.PaymentRule", b =>
                {
                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EmployeeApp.Models.WorkingHour", b =>
                {
                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
