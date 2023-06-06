using AccProdEnterprise.Data;
using AccProdEnterprise.Entities;

namespace AccProdEnterprise.Services
{
    public class DepartmentService
    {
        public ApplicationDbContext _context;

        public DepartmentService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddDepartment(Department newDepartment)
        {
            _context.Departments.Add(newDepartment);
            _context.SaveChanges();
        }

        public void DeleteDepartment(string newDepartmentName)
        {
            var department = _context.Departments
               .Where(department => department.NameDepartment == newDepartmentName)
               .FirstOrDefault();
            department.IsDeleted = true;
            _context.SaveChanges();
        }

        public Department GetDepartment(string newDepartmentName)
        {
            return _context.Departments
                .Where(department => department.NameDepartment == newDepartmentName && department.IsDeleted == false)
                .FirstOrDefault();
        }

        public void UpdateDepartment(string newDepartmentName, Department newDepartment)
        {
            var updateDepartment = _context.Departments
                .Where(department => department.NameDepartment == newDepartmentName)
                .FirstOrDefault();
            updateDepartment = newDepartment;
            _context.SaveChanges();
        }
    }
}
