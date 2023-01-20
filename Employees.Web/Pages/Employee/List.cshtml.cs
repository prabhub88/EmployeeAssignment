using AutoMapper;
using Core.Repository;
using DomainModels.DataModels;
using DomainModels.DTOs.Employee;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Employees.Web.Pages.Employee
{
    public class ListModel : PageModel
    {
        private readonly IEmployeeRepo _employeeRepo;
        public readonly IMapper _mapper;
        private readonly ILogger<ListModel> _logger;

        public List<Read_Employee_Dto> list_employyes { get; set; } = new List<Read_Employee_Dto>();

        public Create_Employee_Dto Create_Employee { get; set; }
        [BindProperty]
        public int canShowModelPoup { get; set; }

        [BindProperty]
        public List<Read_EmployeeSalary_Dto> list_emp_sal { get; set; } = new List<Read_EmployeeSalary_Dto>();
        public ListModel(IEmployeeRepo employeeRepo, IMapper mapper, ILogger<ListModel> logger)
        {
            _employeeRepo = employeeRepo;
            _mapper = mapper;
            _logger = logger;
        }
        public void OnGet()
        {
            var emps = _employeeRepo.GetAllEmployee();
            list_employyes = _mapper.Map<List<Read_Employee_Dto>>(emps);
        }

        public void OnPostEmpIdClick(int empid)
        {
            _logger.LogInformation("LOG : getting salary for {0}",empid.ToString());
            var emp = _employeeRepo.getSalaryById(empid);
            list_emp_sal = _mapper.Map<List<Read_EmployeeSalary_Dto>>(emp);
            canShowModelPoup = 1;
            var emps = _employeeRepo.GetAllEmployee();
            list_employyes = _mapper.Map<List<Read_Employee_Dto>>(emps);
        }

    }
}
