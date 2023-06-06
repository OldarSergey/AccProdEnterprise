using AccProdEnterprise.Entities;
using AccProdEnterprise.Entities.DTO;
using AccProdEnterprise.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccProdEnterprise.Pages
{

    //Потом мы биндим этот класс ээээ... ну потом в методе OnPost прописываем логику 
    //2
    public class Employees : PageModel
    {
        private readonly IEmployeeSercice _employeeSercice;
        private readonly IPositionService _positionService;

        [BindProperty]
        public IEnumerable<Employee> EmployeesList { get; set; }
        public Employees(IEmployeeSercice employeeSercice, IPositionService positionService)
        {
            _employeeSercice = employeeSercice;
            _positionService = positionService;
        }


        [FromRoute]
        [BindProperty(SupportsGet = true)]
        public string FileName { get; set; }


      

        public void OnGet()
        {
            EmployeesList = _employeeSercice.GetEmployeesAll();

        }

      
        public IActionResult OnPostDelete(int id)
        {
            _employeeSercice.DeleteEmployee(id);
            return RedirectToPage("Employees");
        }
    }
}
