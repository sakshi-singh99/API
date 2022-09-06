using Microsoft.EntityFrameworkCore;
using SolrNet;
using System.Configuration;
using WebApiApplication;
using WebApiApplication.viewModel;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EmployeeDbContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("MyCS"),
    Po=>Po.EnableRetryOnFailure()));
var app = builder.Build();
//void ConfigureServices(IServiceCollection services)
//{
//    services.AddControllers();
//    services.AddDbContext<PEPDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MyCS")));
//}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

