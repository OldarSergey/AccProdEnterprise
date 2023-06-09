using AccProdEnterprise.Entities;
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

        [BindProperty]
        public string SortEmployee { get; set; }

        [BindProperty]
        public string SearchEmployeeLastName { get; set; }

        public void OnGet()
        {
            EmployeesList = _employeeSercice.GetEmployeesAll();   
        }

        public IActionResult OnPost()
        {
            return Page();
        }


        public IActionResult OnPostDelete(int id)
        {
            _employeeSercice.DeleteEmployee(id);
            return RedirectToPage("Employees");
        }

        public IActionResult OnPostSortEmployee()
        {
            switch (SortEmployee)
            {
                case "1":
                    EmployeesList = _employeeSercice.GetEmployeesAll();
                    return Page();

                case "2":
                    EmployeesList = _employeeSercice.SortEmployeeLastName();
                    return Page();

                case "3":
                    EmployeesList = _employeeSercice.SortEmployeeFirstName();
                    return Page();

                case "4":
                    EmployeesList = _employeeSercice.SortEmployeePosition();
                    return Page();

                default: return Page();
            }
        }
        public IActionResult OnPostSerchEmployee()
        {
            EmployeesList = _employeeSercice.SearchEmployeeLastName(SearchEmployeeLastName);
            return Page();
        }
    }
}
