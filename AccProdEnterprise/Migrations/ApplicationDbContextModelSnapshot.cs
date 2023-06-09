﻿// <auto-generated />
using System;
using AccProdEnterprise.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AccProdEnterprise.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AccProdEnterprise.Entities.AdmissionDismissalOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfOrders")
                        .HasMaxLength(100)
                        .HasColumnType("date");

                    b.Property<string>("ReasonOfDismissal")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("StaffDepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("TypeOfOrder")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id")
                        .HasName("PK_AdmissionDismissalOrder_Id");

                    b.HasIndex("StaffDepartmentId");

                    b.ToTable("AdmissionDismissalOrders");
                });

            modelBuilder.Entity("AccProdEnterprise.Entities.AdvancedTrainingCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CourseEndDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("CourseStartDate")
                        .HasColumnType("date");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("NameOfCourse")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Organizer")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("PK_AdvancedTrainingCourses_Id");

                    b.ToTable("AdvancedTrainingCourses");
                });

            modelBuilder.Entity("AccProdEnterprise.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FullNameOfTheHead")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("NameDepartment")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id")
                        .HasName("PK_Departments_Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("AccProdEnterprise.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Middlename")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NumberPhone")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<int>("PositionName")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_Employees_Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("PositionId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("AccProdEnterprise.Entities.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfCreate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DateOfDelete")
                        .HasColumnType("datetime");

                    b.Property<string>("Descripton")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("EducationRequirement")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("NamePost")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal");

                    b.HasKey("Id")
                        .HasName("PK_Positions_Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("AccProdEnterprise.Entities.StaffDepartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id")
                        .HasName("PK_StaffDepartments_Id");

                    b.ToTable("StaffDepartments");
                });

            modelBuilder.Entity("AccProdEnterprise.Entities.Tablesheet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("ArrivalTime")
                        .HasMaxLength(100)
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DepartureTime")
                        .HasMaxLength(100)
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("QtyHoursWorked")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<string>("TypeWork")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id")
                        .HasName("PK_Tablesheets_Id");

                    b.ToTable("Tablesheets");
                });

            modelBuilder.Entity("AccProdEnterprise.Entities.VacationApplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfSubmission")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("PlannedEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PlannedStartDate")
                        .HasColumnType("datetime");

                    b.Property<int>("QtyOfDays")
                        .HasColumnType("integer");

                    b.Property<string>("RejectsReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StaffDepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("StatusApplication")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id")
                        .HasName("PK_Applications_Id");

                    b.HasIndex("StaffDepartmentId");

                    b.ToTable("VacationApplications");
                });

            modelBuilder.Entity("AccProdEnterprise.Entities.AdmissionDismissalOrder", b =>
                {
                    b.HasOne("AccProdEnterprise.Entities.StaffDepartment", "StaffDepartment")
                        .WithMany("AdmissionDismissalOrders")
                        .HasForeignKey("StaffDepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_AdmissionDismissalOrders_StaffDepartmentsId_StaffDepartments_Id");

                    b.Navigation("StaffDepartment");
                });

            modelBuilder.Entity("AccProdEnterprise.Entities.Employee", b =>
                {
                    b.HasOne("AccProdEnterprise.Entities.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Employees_DepartmentId_Department_Id");

                    b.HasOne("AccProdEnterprise.Entities.Position", "Position")
                        .WithMany("Employees")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Employees_PositionId_Positions_Id");

                    b.Navigation("Department");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("AccProdEnterprise.Entities.VacationApplication", b =>
                {
                    b.HasOne("AccProdEnterprise.Entities.StaffDepartment", "StaffDepartment")
                        .WithMany("VacationApplications")
                        .HasForeignKey("StaffDepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_VacationApplications_StaffDepartmentsId_StaffDepartments_Id");

                    b.Navigation("StaffDepartment");
                });

            modelBuilder.Entity("AccProdEnterprise.Entities.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("AccProdEnterprise.Entities.Position", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("AccProdEnterprise.Entities.StaffDepartment", b =>
                {
                    b.Navigation("AdmissionDismissalOrders");

                    b.Navigation("VacationApplications");
                });
#pragma warning restore 612, 618
        }
    }
}
