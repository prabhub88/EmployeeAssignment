using System.ComponentModel.DataAnnotations;

namespace DomainModels.DTOs.Employee
{
    public class Read_EmployeeSalary_Dto
    {
        public int EmployeeId { get; set; }
        [DataType(DataType.Date)]
        public DateTime SalaryDate { get; set; }
        public decimal Amount { get; set; }
    }
}
