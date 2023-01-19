using AutoMapper;
using Core.Repository;
using mdl=DomainModels.DataModels;
using DomainModels.DTOs.Employee;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Employees.Web.Pages.Employee
{
    public class CreateModel : PageModel
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepo _employeeRepo;

        public CreateModel(IMapper mapper,IEmployeeRepo employeeRepo)
        {
            _mapper = mapper;
            _employeeRepo = employeeRepo;
        }

        [BindProperty]
        public Create_Employee_Dto employees { get; set; }
        [BindProperty]
        public int employeeId { get; set; }
        public void OnGet()
        {
        }

        public ActionResult OnPost() {

            if (ModelState.IsValid)
            {
                var dbEmpModel = _mapper.Map<mdl.Employees>(employees);
                dbEmpModel.CreatedDate = DateTime.Now;
                dbEmpModel.Id = employeeId;
                _employeeRepo.addEmployee(dbEmpModel);
               return RedirectToPage("List");
            }
            return null;
        }

        public void OnGetEmpIdClick(int empid)
        {
            var emp = _employeeRepo.findById(empid);
            employeeId = emp.Id;
          employees = _mapper.Map<Create_Employee_Dto>(emp);
        }
    }
}
