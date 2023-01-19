using AutoMapper;
using Core.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAssignment.Controllers
{
    public class HController : Controller
    {
        private readonly IMapper? _mapper;
        private readonly IEmployeeRepo? _employeeRepo;
        public HController(IMapper? mapper, IEmployeeRepo? employeeRepo)
        {
            _mapper = mapper;
            _employeeRepo = employeeRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
