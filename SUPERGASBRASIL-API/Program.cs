using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using SUPERGASBRASIL_API.Mappers.Models.InputModel;
using SUPERGASBRASIL_API.Mappers.Profiles;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces;
using SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryAdmin;
using SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryClientLegal;
using SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryClientNatural;
using SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryEmployee;
using SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryReport;
using SUPERGASBRASIL_API.Repositories.Repositorios.RepositorySales;
using SUPERGASBRASIL_API.Services.Interfaces;
using SUPERGASBRASIL_API.Services.ServicesImplementation;
using SUPERGASBRASIL_API.Validators;
using System.Reflection;
using System.Text.Json.Serialization;


var builder = WebApplication.CreateBuilder(args);

var ConnectionString = builder.Configuration.GetConnectionString("");

builder.Services.AddDbContext<GasContext>(o => o.UseSqlServer(ConnectionString));



// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
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

// Registrar validadores
builder.Services.AddTransient<IValidator<Admin_InputModel>, Admin_InputValidator>();
builder.Services.AddTransient<IValidator<ClientLegal_InputModel>, ClientLegal_InputValidator>();
builder.Services.AddTransient<IValidator<ClientNatural_InputModel>, ClientNatural_InputValidator>();
builder.Services.AddTransient<IValidator<Employees_InputModel>, Employee_InputValidator>();


builder.Services.AddSwaggerGen(opt =>
{
    opt.SwaggerDoc("v1", new OpenApiInfo { Title = "SUPERGASBRASIL_API", Version = "v1" });

    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    opt.IncludeXmlComments(xmlPath);
});

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
