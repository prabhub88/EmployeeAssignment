using Core.Repository;
using Employees.Web.Middlewares;
using EntityFrameWorkDAL.Employ;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<EmployeeContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("EmpConnectionstr")));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddTransient<IEmployeeRepo, EmployeRepo>();

builder.Host.UseSerilog((ctx,lc)=>lc.WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Day));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.UseMiddleware<ExceptionHandlerMiddleware>();

app.Run();
