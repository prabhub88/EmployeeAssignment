using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModels.DataModels;

namespace EntityFrameWorkDAL.Employ
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        }

        public DbSet<Employees> Employees { get; set; } = default!;
        public DbSet<EmployeeSalary> Salary { get; set; } = default!;
    }
}
