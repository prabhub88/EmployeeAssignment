using System.ComponentModel.DataAnnotations;

namespace DomainModels.DTOs.Employee
{
    public class Create_EmployeeSalary_Dto
    {
        public int Employee_Id { get; set; }
        [Required(ErrorMessage = "Please choose date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime SalaryDate { get; set; }
        [Required(ErrorMessage = "Please enter salary")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Invalid Salary")]
        public decimal Amount { get; set; }
    }
}
