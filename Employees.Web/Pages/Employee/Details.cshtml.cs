using AutoMapper;
using Core.Repository;
using DomainModels.DTOs.Employee;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Employees.Web.Pages.Employee
{
    public class DetailsModel : PageModel
    {
        private readonly IEmployeeRepo _employeeRepo;
        private readonly IMapper _mapper;
        public List<Read_Employee_Dto> list_employyes { get; set; }
        public DetailsModel(IEmployeeRepo employeeRepo,IMapper mapper)
        {
            _employeeRepo = employeeRepo;
            _mapper = mapper;
        }
        public void OnGet()
        {
          var emps = _employeeRepo.GetAllEmployee();
            list_employyes = _mapper.Map<List<Read_Employee_Dto>>(emps);
        }
    }
}
