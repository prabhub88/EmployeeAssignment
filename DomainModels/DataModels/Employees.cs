using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModels.DataModels
{
    public class Employees
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int Id { get; set; }
        [Required(ErrorMessage = "First Name required")]
        [StringLength(100, ErrorMessage = "max 100 char")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name required")]
        [StringLength(100, ErrorMessage = "Max 100 char allowed")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "City name required")]
        [StringLength(100, ErrorMessage = "Max 100 char allowed")]
        public string City { get; set; }
        [Required(ErrorMessage = "Zip code required")]
        [StringLength(10, ErrorMessage = "Max 10 char allowed")]
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip")]
        public string Zip { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }

    }
}
