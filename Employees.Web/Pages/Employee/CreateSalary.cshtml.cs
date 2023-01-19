using AutoMapper;
using Core.Repository;
using DomainModels.DataModels;
using DomainModels.DTOs.Employee;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace Employees.Web.Pages.Employee
{
    public class CreateSalaryModel : PageModel
    {
        private readonly IEmployeeRepo _employeeRepo;
        private readonly IMapper _mapper;

        public CreateSalaryModel(IEmployeeRepo  employeeRepo,IMapper mapper)
        {
           _employeeRepo = employeeRepo;
            _mapper = mapper;
        }
        [BindProperty]
        
        public Create_EmployeeSalary_Dto employeeSalary { get; set; }

        [BindProperty,Required(ErrorMessage ="Please enter employee id")]
        public int search_employeeID { get; set; }
        [BindProperty]
        public string first_name { get; set; }
        [BindProperty]
        public string last_ame { get; set; }
        [BindProperty]
        public string showSearchError { get; set; } = string.Empty;

            public void OnGet()
        {

        }
        
        public ActionResult OnPost()
        {
            if(employeeSalary.SalaryDate == DateTime.MinValue)
            {
                ModelState.AddModelError("SalaryDate","Please choose date");
                return Page();
            }
            if (employeeSalary.Amount <= 0)
            {
                ModelState.AddModelError("Amount", "Please enter correct amount");
                return Page();
            }

            var dbEmpsalModel = _mapper.Map<EmployeeSalary>(employeeSalary);
                dbEmpsalModel.CreatedDate = DateTime.Now;
                dbEmpsalModel.EmployeeId = search_employeeID;
                _employeeRepo.addSalaryAsync(dbEmpsalModel);
                return RedirectToPage("List");
            
        }

        public void OnPostSearchEmployee()
        {
            if(search_employeeID > 0)
            {
                showSearchError = string.Empty;
                var emp = _employeeRepo.findById(search_employeeID);
                if (emp != null && emp.Id > 0)
                {
                    var emp_dto = _mapper.Map<Read_Employee_Dto>(emp);
                    employeeSalary.Employee_Id = search_employeeID;
                    first_name = emp.FirstName;
                    last_ame = emp.LastName;
                }
                else
                    showSearchError = "Employee could not be found";
            }
            else
            {
                showSearchError = "Please enter valid employee ID";
            }
        }
    }
}
