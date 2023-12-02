
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using appGIUCT;
using appGIUCT.Domain.Repository;
using appGIUCT.Domain.Entities;

var builder = WebApplication.CreateBuilder(args);
var host = builder.Host;
var configuration = builder.Configuration;
var services = builder.Services;




services.AddDbContext<GIUCTDbContext>();

services.AddScoped<IUnitOfWork, UnitOfWork>();


// Agrego Controllers
services.AddControllers();

var app = builder.Build();






app.MapControllers();

app.MapGet("/", () => "Hello World!");


app.Run();


//     //retrieve all the students from the database
//     foreach (var s in context.Students) {
//         Console.WriteLine($"First Name: {s.FirstName}, Last Name: {s.LastName}");
//     }    
// }
///////////////////////

