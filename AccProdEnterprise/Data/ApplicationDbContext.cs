using AccProdEnterprise.Entities;
using Microsoft.EntityFrameworkCore;

namespace AccProdEnterprise.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<AdmissionDismissalOrder> AdmissionDismissalOrders  { get; set; }
        public DbSet<AdvancedTrainingCourse> AdvancedTrainingCourses{ get; set; }
        public DbSet<Department> Departments{ get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<StaffDepartment> StaffDepartments{ get; set; }
        public DbSet<Tablesheet> Tablesheets{ get; set; }
        public DbSet<VacationApplication> VacationApplications{ get; set; }

    }
}
