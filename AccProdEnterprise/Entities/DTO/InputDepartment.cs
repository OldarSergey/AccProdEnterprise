using System.ComponentModel.DataAnnotations;

namespace AccProdEnterprise.Entities.DTO
{
	public class InputDepartment
	{
        [Required]
        [StringLength(100, ErrorMessage = "Max length is {1}") ]
        [Display(Name ="NameDepartment")]
        public string NameDepartment { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "pampampum")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [StringLength(100, ErrorMessage ="Papapum")]
        [Display(Name = "NameOfTheHead")]
        public string FullNameOfTheHead { get; set; }
    }
}
