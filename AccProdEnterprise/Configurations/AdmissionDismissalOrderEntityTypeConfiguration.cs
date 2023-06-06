using AccProdEnterprise.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class AdmissionDismissalOrderEntityTypeConfiguration : IEntityTypeConfiguration<AdmissionDismissalOrder>
{
    public void Configure(EntityTypeBuilder<AdmissionDismissalOrder> builder)
    {

        builder.HasKey(order => order.Id)
            .HasName("PK_AdmissionDismissalOrder_Id");

        builder.Property(order => order.TypeOfOrder)
            .IsRequired()
            .HasMaxLength(100)
            .HasColumnType("nvarchar");

        builder.Property(order => order.DateOfOrders)
            .HasMaxLength(100)
            .HasColumnType("date");

        builder.Property(order => order.ReasonOfDismissal)
            .HasMaxLength(100)
            .HasColumnType("nvarchar");

        builder.HasOne(order => order.StaffDepartment)
            .WithMany(staff => staff.AdmissionDismissalOrders)
            .HasForeignKey(order => order.StaffDepartmentId)
            .HasConstraintName("FK_AdmissionDismissalOrders_StaffDepartmentsId_StaffDepartments_Id");

           
    }
}

