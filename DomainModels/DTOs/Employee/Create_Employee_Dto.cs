
using System.ComponentModel.DataAnnotations;

namespace DomainModels.DTOs.Employee
{
    public class Create_Employee_Dto
    {
        [Required(ErrorMessage = "First Name required")]
        [StringLength(100, ErrorMessage = "max 100 char")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name required")]
        [StringLength(100, ErrorMessage = "max 100 char")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "City name required")]
        [StringLength(100, ErrorMessage = "Max 100 char allowed")]
        public string City { get; set; }
        [Required(ErrorMessage = "Zip code required")]
        [StringLength(10, ErrorMessage = "Max 10 char allowed")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Invalid Zip")]
        public string Zip { get; set; }
    }
}
