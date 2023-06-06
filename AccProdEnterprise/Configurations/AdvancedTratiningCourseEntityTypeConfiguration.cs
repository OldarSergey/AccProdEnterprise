using AccProdEnterprise.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccProdEnterprise.Configurations
{
    public class AdvancedTratiningCourseEntityTypeConfiguration : IEntityTypeConfiguration<AdvancedTrainingCourse>
    {
        public void Configure(EntityTypeBuilder<AdvancedTrainingCourse> builder)
        {
            builder.HasKey(advanced => advanced.Id)
                .HasName("PK_AdvancedTrainingCourses_Id");

            builder.Property(advanced => advanced.NameOfCourse)
               .IsRequired()
               .HasMaxLength(50)
               .HasColumnType("nvarchar");

            builder.Property(advanced => advanced.CourseStartDate)
               .IsRequired()
               .HasColumnType("date");

            builder.Property(advanced => advanced.CourseEndDate)
               .IsRequired()
               .HasColumnType("date");

            builder.Property(advanced => advanced.Category)
               .IsRequired()
               .HasMaxLength(50)
               .HasColumnType("nvarchar");

            builder.Property(advanced => advanced.Organizer)
             .IsRequired()
             .HasMaxLength(50)
             .HasColumnType("nvarchar");

            //builder.HasMany(advanced => advanced.Employees)
            //    .WithOne(employee => employee.AdvancedTrainingCourse)
            //    .HasForeignKey(advanced => advanced.AdvancedTrainingCourseId)
            //    .HasConstraintName("FK_Employees_AdvancedTrainingCourseId_AdvancedTrainingCourse_Id");
                
                


        }
    }
}
