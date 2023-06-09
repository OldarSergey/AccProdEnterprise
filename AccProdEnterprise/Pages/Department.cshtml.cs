using AccProdEnterprise.Entities;
using AccProdEnterprise.Entities.DTO;
using AccProdEnterprise.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccProdEnterprise.Pages
{
    public class DepartmentModel : PageModel
    {
        private readonly IDepartmentService _departmentService;

        [BindProperty]
        public InputDepartment InputModel { get; set; }
        public DepartmentModel(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [BindProperty]
        public InputDepartment inputDepartment { get; set; }


        [BindProperty]
        public IEnumerable<Department> Departments { get; set; }


        public void OnGet()
        {
            Departments = _departmentService.GetDepartmentAll();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var department = new Department()
            {
                NameDepartment = InputModel.NameDepartment,
                Description = InputModel.Description,
                FullNameOfTheHead = InputModel.FullNameOfTheHead
            };
            _departmentService.AddDepartment(department);
            ViewData["Message"] = "The addition was completed successfully";
            return Page();
        }
    }
}
