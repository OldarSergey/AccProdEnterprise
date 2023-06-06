using AccProdEnterprise.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccProdEnterprise.Configurations
{
    public class VacationApplicationEntityTypeConfiguration : IEntityTypeConfiguration<VacationApplication>
    {
        public void Configure(EntityTypeBuilder<VacationApplication> builder)
        {
            builder.HasKey(application => application.Id)
                .HasName("PK_Applications_Id");

            builder.Property(application => application.DateOfSubmission)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(application => application.PlannedStartDate)
               .IsRequired()
               .HasColumnType("datetime");

            builder.Property(application => application.QtyOfDays)
               .IsRequired()
               .HasColumnType("integer");

            builder.Property(application => application.StatusApplication)
               .IsRequired()
               .HasMaxLength(200)
               .HasColumnType("nvarchar");

            builder.HasOne(application => application.StaffDepartment)
                .WithMany(staff => staff.VacationApplications)
                .HasForeignKey(application => application.StaffDepartmentId)
                .HasConstraintName("FK_VacationApplications_StaffDepartmentsId_StaffDepartments_Id");



        }
    }
}
