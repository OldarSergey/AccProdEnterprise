using AccProdEnterprise.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccProdEnterprise.Configurations
{
    public class DepartmentEntityTypeConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(department => department.Id)
                .HasName("PK_Departments_Id");

            builder.Property(department => department.NameDepartment)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            builder.Property(department => department.Description)
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            builder.Property(department => department.FullNameOfTheHead)
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            //builder.HasOne(department => department.StaffDepartment)
            //    .WithMany(staff => staff.Departments)
            //    .HasForeignKey(department => department.StaffDepartmentId)
            //    .HasConstraintName("FK_Departments_StaffDepartmentsId_StaffDepartments_Id");



        }
    }
}
