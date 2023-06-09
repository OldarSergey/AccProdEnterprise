using AccProdEnterprise.Data;
using AccProdEnterprise.Entities;
using AccProdEnterprise.Pages;
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

        public List<Employee> SortEmployeeLastName()
        {
            return _context.Employees
                .Include(e => e.Position)
                .Where(e => e.IsDeleted == false)
                .OrderBy(e => e.Lastname)
                .ToList();
        }

        public List<Employee> SortEmployeeFirstName()
        {
            return _context.Employees
                  .Include(e => e.Position)
                  .Where(e => e.IsDeleted == false)
                  .OrderBy(e => e.Firstname)
                  .ToList();
        }

        public List<Employee> SortEmployeePosition()
        {
            return _context.Employees
                .Include(e => e.Position)
                .Where(e => e.IsDeleted ==false)
                .OrderBy(e => e.Position.NamePost)
                .ToList();
        }

        public List<Employee> SearchEmployeeLastName(string lastName)
        {
            return _context.Employees
                .Where(e => e.IsDeleted == false && e.Lastname == lastName)
                .Include(e => e.Position)
                .ToList();
        }

        public void UpdateEmployee(int idEmployee, Employee newProduct)
        {
            var employees = _context.Employees
                .Where(product => product.Id == idEmployee)
                .FirstOrDefault();
            employees.IsDeleted = true;

            _context.Employees.Add(newProduct);
            _context.SaveChanges();
        }
        public IEnumerable<Employee> GetProductsById(int employeeId)
        {
            return _context.Employees
                .Where(pr => pr.IsDeleted == false && pr.Id == employeeId)
                .ToList();
        }

    }
}
