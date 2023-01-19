using Core.Repository;
using EntityFrameWorkDAL.Employ;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AutoMapper;

namespace Employees.Web.Pages.Employee
{
    public class IndexModel : PageModel
    {
        private readonly IEmployeeRepo _employeeRepo;
        private readonly IMapper _mapper;

        public IndexModel(IEmployeeRepo employeeRepo, IMapper mapper)
        {
            _employeeRepo = employeeRepo;
            _mapper = mapper;
        }
        public void OnGet()
        {
        }
    }
}
