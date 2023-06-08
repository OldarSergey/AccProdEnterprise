using AccProdEnterprise.Entities.DTO;
using AccProdEnterprise.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccProdEnterprise.Pages
{
    public class DepartmentsModel : PageModel
    {
        public readonly IDepartmentService _departmentService;

        [BindProperty]
        public InputDepartment InputModel { get; set; }

        public DepartmentsModel(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
         
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return Page();
        }
    }
}
