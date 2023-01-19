using AutoMapper;
using Core.Repository;
using DomainModels.DataModels;
using Microsoft.AspNetCore.Mvc;
using DomainModels.DTOs.Employee;
namespace EmployeeAssignment.Controllers
{

    public class EmployeeController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepo _employeeRepo;
        public EmployeeController(IMapper mapper, IEmployeeRepo employeeRepo)
        {
            //_mapper = mapper;
          //  _employeeRepo = employeeRepo;
        }

        // GET: EmployeeController
        public ActionResult Index()
        {
            try
            {
                return View();
            }
            catch(Exception ex) { 
                throw ex; }
            
        }

         // GET: EmployeeController/Create
        public ActionResult Create()
        {
           /* Create_Employee_Dto dtoa = new Create_Employee_Dto();
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
