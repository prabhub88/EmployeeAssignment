using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Core.Repository;
using DomainModels.DTOs.Employee;
using DomainModels.DataModels;

namespace EmployeeAssignment.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IMapper? _mapper;
      private readonly IEmployeeRepo? _employeeRepo;
        public EmployeesController(IMapper? mapper, IEmployeeRepo? employeeRepo)
        {
            _mapper = mapper;
            _employeeRepo = employeeRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
             /*Create_Employee_Dto dtoa = new Create_Employee_Dto();
             dtoa.City = "Arasampattti";
             dtoa.Zip = 334333;
             dtoa.FirstName = "Ruba1";
             dtoa.LastName = "Prabhu1";
             _employeeRepo.addEmployee(_mapper.Map<Employees>(dtoa));

             Create_EmployeeSalary_Dto dt = new Create_EmployeeSalary_Dto();
             dt.Amount = 100000.23M;
             dt.SalaryDate = DateTime.Now.AddDays(2);
             var empSalary = _mapper.Map<EmployeeSalary>(dt);
             empSalary.CreatedDate = DateTime.Now;
             empSalary.EmployeeId = 1;
             _employeeRepo.addSalaryAsync(empSalary);*/
            return View();
        }
    }
}
