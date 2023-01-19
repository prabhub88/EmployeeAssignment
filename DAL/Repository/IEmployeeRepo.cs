using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DomainModels.DataModels;

namespace Core.Repository
{
    public interface IEmployeeRepo :IDisposable
    {
        public int addEmployee(Employees employeeModel);
        public int updateEmployee(Employees employeeModel);
        public int deleteEmployee(Employees employeeModel);
        public Employees? findById(int id);
        public Employees? findByName(string name);
        public List<Employees> GetAllEmployee();
        public int addSalaryAsync(EmployeeSalary employeeSalary);
        public List<EmployeeSalary> getSalaryById(int employeeID);
    }
}
