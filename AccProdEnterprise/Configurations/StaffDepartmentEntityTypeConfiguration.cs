using AccProdEnterprise.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccProdEnterprise.Configurations
{
    public class StaffDepartmentEntityTypeConfiguration : IEntityTypeConfiguration<StaffDepartment>
    {
        public void Configure(EntityTypeBuilder<StaffDepartment> builder)
        {
            builder.HasKey(staff => staff.Id)
                .HasName("PK_StaffDepartments_Id");


        }
    }
}
