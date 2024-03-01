using RestWithASPNET.Services.Implementations;
using RestWithASPNET.Services;
using RestWithASPNET.Model.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var connection = builder.Configuration["MysSQLConnection : MysSQLConnectionString"];
builder.Services.AddDbContext<MysqlContext>(options => options.UseMySql(
    connection,
    new MySqlServerVersion(new Version(8,0,34))
    ));

//Dependency Injection
builder.Services.AddScoped<IPersonService, PersonServiceImplemetation>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
