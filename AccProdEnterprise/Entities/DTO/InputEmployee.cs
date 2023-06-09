using System.ComponentModel.DataAnnotations;

namespace AccProdEnterprise.Entities.DTO
{
    //Для того чтобы создать форму для начала надо создать InputModel который будет хранить в себе входные данные от пользователя, там мы прописываем
    //Дата аннотации (проверки)
    //1
    public class InputEmployee
    {
        [Required]
        [StringLength(100, ErrorMessage = "Max limit {1}")]
        [Display(Name = "LastName" ) ]
        public string Lastname { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Max limit {1}")]
        [Display(Name = "FirstName")]
        public string Firstname { get; set; }

        [StringLength(100, ErrorMessage = "Max limit {1}")]
        [Display(Name = "MiddleName")]
        public string? Middlename { get; set; }

        [Required]
        [DataType(DataType.Date, ErrorMessage = "Not valid date")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Max limit {1}")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [Phone]
        [StringLength(12, ErrorMessage = "Max limit {1}")]
        [Display (Name ="PhoneNumber")]
        public string NumberPhone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required(ErrorMessage = "Required field")]
        [Display(Name = "Positions")]
        public int SelectedValuePositions { get; set; }

        [Required(ErrorMessage = "Required field")]
        [Display(Name = "Departments ")]
        public int SelectedValueDepartments { get; set; }

    }
}
