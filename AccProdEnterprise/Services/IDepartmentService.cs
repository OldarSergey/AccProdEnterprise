using AccProdEnterprise.Entities;

namespace AccProdEnterprise.Services
{
    public interface IDepartmentService
    {
        public void AddDepartment(Department newDepartment);
        public void DeleteDepartment(string newDepartmentName);
        public void UpdateDepartment(string newDepartmentName, Department newDepartment);
        public Department GetDepartment(string newDepartmentName);

        public List<Department> GetDepartmentAll();

    }
}
