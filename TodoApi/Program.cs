using Microsoft.EntityFrameworkCore;
using Induvidueel_ProjectAPI.Models;
using IndividueelProjectLU2.WebApi.Repositories;
using Induvidueel_ProjectAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Get connection string from appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Register repositories with the connection string
builder.Services.AddSingleton<IEnvironment2DRepository>(new Environment2DRepository(connectionString));
builder.Services.AddSingleton<IObject2DRepository>(new Object2DRepository(connectionString));

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
