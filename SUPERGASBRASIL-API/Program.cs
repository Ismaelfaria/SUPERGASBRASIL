using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceAdmin;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientLegal;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientNatural;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceEmployees;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceReport;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceSales;
using SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryAdmin;
using SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryClientLegal;
using SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryClientNatural;
using SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryEmployee;
using SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryReport;
using SUPERGASBRASIL_API.Repositories.Repositorios.RepositorySales;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceAdmin;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceClientLegal;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceClientNatural;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceEmployees;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceReport;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceSales;
using SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesAdmin;
using SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesClientLegal;
using SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesClientNatural;
using SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesEmployee;
using SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesReport;
using SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesSales;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Repository Admin
builder.Services.AddScoped<ICreateA,CreateA>();
builder.Services.AddScoped<IUpdateA, UpdateA>();
builder.Services.AddScoped<IGetA, GetA>();
builder.Services.AddScoped<IDeleteA, DeleteA>();

//Repository ClientLegal
builder.Services.AddScoped<ICreateClientL, CreateClientL >();
builder.Services.AddScoped<IUpdateClientL, UpdateClientL>();
builder.Services.AddScoped<IGetClientL, GetClientL>();
builder.Services.AddScoped<IDeleteClientL, DeleteClientL>();

//Repository ClientNatural
builder.Services.AddScoped<ICreateClientN, CreateClientN>();
builder.Services.AddScoped<IUpdateClientN, UpdateClientN>();
builder.Services.AddScoped<IGetClientN, GetClientN>();
builder.Services.AddScoped<IDeleteClientN, DeleteClientN>();

//Repository Employee
builder.Services.AddScoped<ICreateE, CreateE>();
builder.Services.AddScoped<IUpdateE, UpdateE>();
builder.Services.AddScoped<IGetE, GetE>();
builder.Services.AddScoped<IDeleteE, DeleteE>();

//Repository Report
builder.Services.AddScoped<ICreateR, CreateR>();
builder.Services.AddScoped<IGetR, GetR>();

//Repository Sales
builder.Services.AddScoped<ICreateS, CreateS>();
builder.Services.AddScoped<IGetS, GetS>();
builder.Services.AddScoped<IDeleteS, DeleteS>();

//////////////////////
//Services

//Services Admin
builder.Services.AddScoped<ICreateServA, CreateSA>();
builder.Services.AddScoped<IUpdateServA, UpdateSA>();
builder.Services.AddScoped<IGetServA, GetSA>();
builder.Services.AddScoped<IDeleteServA, DeleteSA>();

//Services ClientLegal
builder.Services.AddScoped<ICreateServCL, CreateSCL>();
builder.Services.AddScoped<IUpdateServCL, UpdateSCL>();
builder.Services.AddScoped<IGetServCL, GetSCL>();
builder.Services.AddScoped<IDeleteServCL, DeleteSCL>();

//Services ClientNatural
builder.Services.AddScoped<ICreateServCN, CreateSCN>();
builder.Services.AddScoped<IUpdateServCN, UpdateSCN>();
builder.Services.AddScoped<IGetServCN, GetSCN>();
builder.Services.AddScoped<IDeleteServCN, DeleteSCN>();

//Services Employee
builder.Services.AddScoped<ICreateServE, CreateSE>();
builder.Services.AddScoped<IUpdateServE, UpdateSE>();
builder.Services.AddScoped<IGetServE, GetSE>();
builder.Services.AddScoped<IDeleteServE, DeleteSE>();

//Services Report
builder.Services.AddScoped<ICreateServR, CreateSR>();
builder.Services.AddScoped<IGetServR, GetSR>();

//Services Sales
builder.Services.AddScoped<ICreateServS, CreateSS>();
builder.Services.AddScoped<IGetServS, GetSS>();
builder.Services.AddScoped<IDeleteServS, DeleteSS>();

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
