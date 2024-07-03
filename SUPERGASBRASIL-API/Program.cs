using FluentValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using SUPERGASBRASIL_API.Repositories.Interfaces.PIT_RepositoryInterfaces;
using SUPERGASBRASIL_API.Repositories.Repositorios;
using SUPERGASBRASIL_API.Repositories.Repositorios.PIT_Repository;
using SUPERGASBRASIL_API.Services.Interfaces.PIT_ServicesInterfaces;
using SUPERGASBRASIL_API.Services.ServicesImplementation.PIT_Services;
using System.Text;
using System.Text.Json.Serialization;
using SUPERGASBRASIL_API.App.Mapping.Models.InputModel;
using SUPERGASBRASIL_API.App.Mapping.Profiles;
using SUPERGASBRASIL_API.App.Services.Interfaces;
using SUPERGASBRASIL_API.App.Services.ServicesImplementation;
using SUPERGASBRASIL_API.App.Services.Interfaces.Token;
using SUPERGASBRASIL_API.App.Services.ServicesImplementation.Token;
using SUPERGASBRASIL_API.App.Interfaces;
using SUPERGASBRASIL_API.App.Validators;
using SUPERGASBRASIL_API.Infra.Context;
using SUPERGASBRASIL_API.Infra.Repositorios;
using SUPERGASBRASIL_API.App.Rest;
using SUPERGASBRASIL_API.App.Rest.Interface;


var builder = WebApplication.CreateBuilder(args);

var ConnectionString = builder.Configuration.GetConnectionString("GasConnection");

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
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();
builder.Services.AddScoped<IInventoryRepository, InventoryRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
//////////////////////

//Services

builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddScoped<IClientLegalService, ClientLegalService>();
builder.Services.AddScoped<IClientNaturalService, ClientNaturalService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ITransactionService, TransactionService>();
builder.Services.AddScoped<IInventoryService, InventoryService>();
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddScoped<IUserService, UserService>();

// Registrar validadores
builder.Services.AddTransient<IValidator<Admin_InputModel>, Admin_InputValidator>();
builder.Services.AddTransient<IValidator<ClientLegal_InputModel>, ClientLegal_InputValidator>();
builder.Services.AddTransient<IValidator<ClientNatural_InputModel>, ClientNatural_InputValidator>();
builder.Services.AddTransient<IValidator<Employees_InputModel>, Employee_InputValidator>();
builder.Services.AddTransient<IValidator<User_InputModel>, User_InputValidator>();
builder.Services.AddTransient<IValidator<Product_InputModel>, Product_InputValidator>();
builder.Services.AddTransient<IValidator<Inventory_InputModel>, Inventory_InputValidator>();
builder.Services.AddSingleton<ICnpjService, CnpjService>();
builder.Services.AddSingleton<IBrasilAPI, BrasilAPI>();

builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Cabeçalho de autorização JWT está usando o esquema de Bearer \r\n\r\n Digite um 'Bearer' antes de colocar um token."
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
{
    {
    new OpenApiSecurityScheme
    {
        Reference = new OpenApiReference
        {
            Type = ReferenceType.SecurityScheme,
            Id = "Bearer"
        }
    },
    Array.Empty<string>()
    }
});
});

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };
    });


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
