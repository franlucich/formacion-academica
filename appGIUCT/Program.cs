
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using appGIUCT;
using appGIUCT.Domain.Repository;
using appGIUCT.Domain.Entities;

var builder = WebApplication.CreateBuilder(args);
var host = builder.Host;
var configuration = builder.Configuration;
var services = builder.Services;
var  MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy  =>
                      {
                          policy.WithOrigins("http://localhost:4200").WithMethods("GET", "POST", "DELETE", "PUT").AllowAnyHeader();
                      });
});


services.AddDbContext<GIUCTDbContext>();

services.AddScoped<IUnitOfWork, UnitOfWork>();


// Agrego Controllers
services.AddControllers();

var app = builder.Build();






app.MapControllers();

app.MapGet("/", () => "Hello World!");

app.UseCors(MyAllowSpecificOrigins);

app.Run();



