using SUPERGASBRASIL_API.Mappers.Profiles;
using SUPERGASBRASIL_API.Repositories.Interfaces;
using SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryAdmin;
using SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryClientLegal;
using SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryClientNatural;
using SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryEmployee;
using SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryReport;
using SUPERGASBRASIL_API.Repositories.Repositorios.RepositorySales;
using SUPERGASBRASIL_API.Services.Interfaces;
using SUPERGASBRASIL_API.Services.ServicesImplementation;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddAutoMapper(typeof(ProfileMapperGas));

//Repository 

builder.Services.AddScoped<IAdminRepository, AdminRepository>();
builder.Services.AddScoped<IClientLegalRepository, ClientLegalRepository>();
builder.Services.AddScoped<IClientNaturalRepository, ClientNaturalRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IReportRepository, ReportRepository>();
builder.Services.AddScoped<ISalesRepository, SalesRepository>();

//////////////////////

//Services

builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddScoped<IClientLegalService, ClientLegalService>();
builder.Services.AddScoped<IClientNaturalService, ClientNaturalService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IReportService, ReportService>();
builder.Services.AddScoped<ISalesService, SalesService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
