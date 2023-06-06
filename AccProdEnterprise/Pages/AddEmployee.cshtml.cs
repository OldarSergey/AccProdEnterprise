using AccProdEnterprise.Entities;
using AccProdEnterprise.Entities.DTO;
using AccProdEnterprise.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AccProdEnterprise.Pages
{
    public class AddEmployeeModel : PageModel
    {

        private readonly IEmployeeSercice _employeeSercice;
        private readonly IPositionService _positionService;

        public AddEmployeeModel(IEmployeeSercice employeeSercice, IPositionService positionService)
        {
            _employeeSercice = employeeSercice;
            _positionService = positionService;
            LoadPositions();
        }


        [BindProperty]
        public InputEmployee InputEmployee { get; set; }
        public List<SelectListItem> PositionItems { get; set; }

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

        public void OnGet()
        {}

        [HttpPost]
        public IActionResult OnPost()
        {


            if (!ModelState.IsValid)
            {
                return Page();
            }

            var employee = new Employee()
            {
                Firstname = InputEmployee.Firstname,
                Lastname = InputEmployee.Lastname,
                Middlename = InputEmployee.Middlename,
                Address = InputEmployee.Address,
                NumberPhone = InputEmployee.NumberPhone,
                Email = InputEmployee.Email,
                DateOfBirth = InputEmployee.DateOfBirth,
                PositionId = InputEmployee.SelectedValuePositions
            };

            _employeeSercice.AddEmoloyee(employee);


            return RedirectToPage("Employees");


        }

    }
}
