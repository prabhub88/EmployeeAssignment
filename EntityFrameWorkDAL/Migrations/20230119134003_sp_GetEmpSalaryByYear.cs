using DomainModels.DataModels;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWorkDAL.Migrations
{
    public partial class sp_GetEmpSalaryByYear : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"  CREATE procedure[dbo].[sp_GetEmpSalaryByYear]
            @EmpId VARCHAR(20)
                AS
                Begin
                Select* from dbo.Salary where EmployeeId = @EmpId
                and YEAR(CreatedDate) = year(GETDATE())
                End";
            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
