using AutoMapper;
using Core.Repository;
using DomainModels.DataModels;
using DomainModels.DTOs.Employee;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Employees.Web.Pages.Employee
{
    public class ShowSalaryModel : PageModel
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepo _employeeRepo;

        public ShowSalaryModel(IMapper mapper, IEmployeeRepo employeeRepo )
        {
            _mapper = mapper;
            _employeeRepo = employeeRepo;
        }
        [BindProperty]
        public List<Read_EmployeeSalary_Dto> employeeSalary { get; set; } 
        public void OnGet()
        {
        }

       
    }
}
