
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
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

services.AddScoped<IUnitOfWork, UnitOfWork>();


// Agrego Controllers
services.AddControllers();


var app = builder.Build();

if(app.Environment.IsDevelopment())
    {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.MapControllers();




app.Run();
