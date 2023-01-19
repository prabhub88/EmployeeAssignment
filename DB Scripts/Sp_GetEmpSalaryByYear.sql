CREATE procedure [dbo].[sp_GetEmpSalaryByYear]
@EmpId VARCHAR(20)
AS
Begin
Select * from dbo.Salary where EmployeeId=@EmpId
and YEAR(CreatedDate) = year(GETDATE())
End