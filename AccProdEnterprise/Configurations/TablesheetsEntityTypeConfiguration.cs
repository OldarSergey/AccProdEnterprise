using AccProdEnterprise.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccProdEnterprise.Configurations
{
    public class TablesheetsEntityTypeConfiguration : IEntityTypeConfiguration<Tablesheet>
    {
        public void Configure(EntityTypeBuilder<Tablesheet> builder)
        {
            builder.HasKey(tablesheets => tablesheets.Id)
                .HasName("PK_Tablesheets_Id");

            builder.Property(tablesheets => tablesheets.ArrivalTime)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("datetime");

            builder.Property(tablesheets => tablesheets.DepartureTime)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("datetime");

            builder.Property(tablesheets => tablesheets.QtyHoursWorked)
                .IsRequired()
                .HasColumnType("integer");

            builder.Property(tablesheets => tablesheets.TypeWork)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("nvarchar");

            builder.HasMany(tablesheets => tablesheets.Employees)
                .WithOne(employee => employee.Tablesheet)
                .HasForeignKey(employee => employee.TablesheetsId)
                .HasConstraintName("FK_Employees_TablesheetsId_Tablesheets_Id");



        }
    }
}
