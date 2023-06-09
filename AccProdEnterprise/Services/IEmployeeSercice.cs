using AccProdEnterprise.Entities;
using AccProdEnterprise.Pages;

namespace AccProdEnterprise.Services
{
    public interface IEmployeeSercice
    {
        public void AddEmoloyee(Employee newEmployee);
        public void DeleteEmployee(int id);
        public void UpdateEmployee(string employeeName, Employee newEmployee);
        public Employee GetEmployee(string newEmployeeName);
        public List<Employee> GetEmployeesAll();

        public List<Employee> SortEmployeeLastName();
        public List<Employee> SortEmployeeFirstName();
        public List<Employee> SortEmployeePosition();
        public List<Employee> SearchEmployeeLastName(string lastName);

        public void UpdateEmployee(int idEmployee, Employee newProduct);

        public IEnumerable<Employee> GetProductsById(int employeeId);




    }
}
