using DriversDevOps.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var conn = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<DriverDbContext>(options => options.UseSqlServer(conn));

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();
//http://localhost:8000/swagger/index.html

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
