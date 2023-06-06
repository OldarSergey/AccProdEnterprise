using AccProdEnterprise.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccProdEnterprise.Configurations
{
    public class PositionEntityTypeConfiguration : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.HasKey(post => post.Id)
                    .HasName("PK_Positions_Id");

            builder.Property(post => post.Id)
                   .ValueGeneratedOnAdd()
                   .UseIdentityColumn();

            builder.Property(post => post.NamePost)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar");

            builder.Property(post => post.Descripton)
                .IsRequired()
                .HasMaxLength(400)
                .HasColumnType("nvarchar");

            builder.Property(post => post.Salary)
                .IsRequired()
                .HasColumnType("decimal");

            builder.Property(post => post.EducationRequirement)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar");

            builder.Property(post => post.DateOfCreate)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(post => post.LastUpdateDate)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(post => post.DateOfDelete)
                .HasColumnType("datetime");






        }
    }
}
