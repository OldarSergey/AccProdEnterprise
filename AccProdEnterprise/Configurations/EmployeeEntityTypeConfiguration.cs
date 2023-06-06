using AccProdEnterprise.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccProdEnterprise.Configurations
{
    public class EmployeeEntityTypeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(employee => employee.Id)
                .HasName("PK_Employees_Id");

            builder.Property(employee => employee.Lastname)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar");

            builder.Property(employee => employee.Firstname)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar");

            builder.Property(employee => employee.Middlename)
                .HasMaxLength(50)
                .HasColumnType("nvarchar");

            builder.Property(employee => employee.DateOfBirth)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(employee => employee.Address)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            builder.Property(employee => employee.NumberPhone)
                .IsRequired()
                .HasMaxLength(12)
                .HasColumnType("nvarchar");

            builder.Property(employee => employee.Email)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar");


            builder.HasOne(emp => emp.Position)
                .WithMany(pos => pos.Employees)
                .HasForeignKey(emp => emp.PositionId)
                .HasConstraintName("FK_Employees_PositionId_Positions_Id");


               





        }
    }
}
