using Core.Repository;
using DomainModels.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkDAL.Employ
{
    public class EmployeRepo : IEmployeeRepo
    {
        private bool disposedValue;
        private readonly EmployeeContext _employeeContext;
        public EmployeRepo(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public int addEmployee(Employees employeeModel)
        {
            _employeeContext.Employees.Update(employeeModel);
            _employeeContext.SaveChanges();
            return 1;
        }

        public int addSalaryAsync(EmployeeSalary employeeSalary)
        {
            _employeeContext.Salary.Update(employeeSalary);
            _employeeContext.SaveChanges();
            return 1;
        }

        public int deleteEmployee(Employees employeeModel)
        {
            throw new NotImplementedException();
        }

        public Employees? findById(int id)
        {
          return _employeeContext.Employees.FirstOrDefault(e => e.Id == id);
        }

        public Employees findByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Employees> GetAllEmployee()
        {
            return _employeeContext.Employees.ToList();
        }

        public List<EmployeeSalary> getSalaryById(int employeeID)
        {
          return  _employeeContext.Salary.FromSqlRaw($"sp_GetEmpSalaryByYear {employeeID}").ToList();
        }

        public int updateEmployee(Employees employeeModel)
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~EmployeRepo()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
