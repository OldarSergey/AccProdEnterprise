using AccProdEnterprise.Data;
using AccProdEnterprise.Entities;
using Microsoft.EntityFrameworkCore;

namespace AccProdEnterprise.Services
{
    public class EmployeeService : IEmployeeSercice
    {
        private readonly ApplicationDbContext _context;

        public EmployeeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Employee> GetEmployeesAll ()
        {
            return _context.Employees
                .Where(e => e.IsDeleted ==  false)
                .Include(e => e.Position)
                .ToList();
        }

        public void AddEmoloyee(Employee newEmployee)
        {
            _context.Employees.Add(newEmployee);
            _context.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            var employee = _context.Employees
                .Where(employee => employee.Id == id)
                .FirstOrDefault();
            employee.IsDeleted = true;
            _context.SaveChanges();
        }

        public Employee GetEmployee(string newEmployeeName)
        {
            return _context.Employees
                .Where(employee => employee.Lastname == newEmployeeName && employee.IsDeleted == false)
                .FirstOrDefault();
                
        }

        public void UpdateEmployee(string employeeName, Employee newEmployee)
        {
            var updateEmployee = _context.Employees
                .Where(employee => employee.Lastname == employeeName)
                .FirstOrDefault();
            updateEmployee = newEmployee;
            _context.SaveChanges();
        }
    }
}
