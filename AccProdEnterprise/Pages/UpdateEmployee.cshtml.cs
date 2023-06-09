using AccProdEnterprise.Entities;
using AccProdEnterprise.Entities.DTO;
using AccProdEnterprise.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AccProdEnterprise.Pages
{
    public class UpdateEmployeeModel : PageModel
    {

        public IEnumerable<Employee> EmployeeId { get; set; }

        [BindProperty]
        public InputEmployee InputEmployee { get; set; }

        private readonly IEmployeeSercice _employeeSercice;
        private readonly IPositionService _positionService;
        private readonly IDepartmentService _departmentService;
        public List<SelectListItem> PositionItems { get; set; }
        public List<SelectListItem> DepartmentsItems { get; set; }

        public UpdateEmployeeModel(IEmployeeSercice employeeSercice, IPositionService positionService,
            IDepartmentService departmentService)
        {
            _employeeSercice = employeeSercice;
            _positionService = positionService;
            _departmentService = departmentService;
            LoadPositions();
            LoadDepartments();
        }

        private void LoadPositions()
        {
            List<Position> positions = _positionService.GetAllPositions();
            PositionItems = positions.Select(t => new SelectListItem
            {
                Value = t.Id.ToString(),
                Text = t.NamePost
            })
            .ToList();

            PositionItems.Insert(0, new SelectListItem { Value = "0", Text = "Отсутствует", Selected = true });
        }
        private void LoadDepartments()
        {
            List<Department> departments = _departmentService.GetDepartmentAll();
            DepartmentsItems = departments.Select(t => new SelectListItem
            {
                Value = t.Id.ToString(),
                Text = t.NameDepartment
            })
            .ToList();

            DepartmentsItems.Insert(0, new SelectListItem { Value = "0", Text = "Отсутствует", Selected = true });
        }


        public void OnGet()
        {
        }
        public void OnPost()
        {

        }
        public IActionResult OnPostUpdateEmployee(int id)
        {
            if (!ModelState.IsValid)
                return Page();
            var employee = new Employee()
            {
                Firstname = InputEmployee.Firstname,
                Lastname = InputEmployee.Lastname,
                Middlename = InputEmployee.Middlename,
                Address = InputEmployee.Address,
                NumberPhone = InputEmployee.NumberPhone,
                Email = InputEmployee.Email,
                DateOfBirth = InputEmployee.DateOfBirth,
                PositionId = InputEmployee.SelectedValuePositions,
                DepartmentId = InputEmployee.SelectedValueDepartments

            };

            _employeeSercice.UpdateEmployee(id,employee);


            return RedirectToPage("Employees");

        }
        public IActionResult OnPostSearchById(int id)
        {
        

            EmployeeId = _employeeSercice.GetProductsById(id);

            return Page();

        }
    }
}
