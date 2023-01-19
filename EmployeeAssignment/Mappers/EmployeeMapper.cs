using AutoMapper;
using DomainModels.DTOs.Employee;
using DomainModels.DataModels;

namespace EmployeeAssignment.Mappers
{
    public class EmployeeMapper : Profile
    {
        public EmployeeMapper()
        {
            CreateMap<Create_Employee_Dto, Employees>();
            CreateMap<Employees, Read_Employee_Dto>();
            CreateMap<Create_EmployeeSalary_Dto, EmployeeSalary>();
            CreateMap<EmployeeSalary, Read_EmployeeSalary_Dto>();
        }
    }
}
