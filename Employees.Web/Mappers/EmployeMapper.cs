using AutoMapper;
using mdl=DomainModels.DataModels;
using DomainModels.DTOs.Employee;

namespace Employees.Web.Mappers
{
    public class EmployeMapper :Profile
    {
        public EmployeMapper()
        {
            CreateMap<Create_Employee_Dto, mdl.Employees>().ReverseMap();
            CreateMap<mdl.Employees, Read_Employee_Dto>()
                .AfterMap((src, dst) => { dst.EmployeeId = src.Id; });
            CreateMap<Create_EmployeeSalary_Dto, mdl.EmployeeSalary>();
            CreateMap<mdl.EmployeeSalary, Read_EmployeeSalary_Dto>();
        }
    }
}
