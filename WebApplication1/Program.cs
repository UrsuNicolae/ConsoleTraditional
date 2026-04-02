using WebApplication1.Middlewares;
using Infrastracture.Extensions;
using System.Dynamic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRepos();
builder.Services.AddDbContext();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseMiddleware<ExceptionMiddleware>();
//app.UseMiddleware<HeaderCheckerMiddleware>("auth");
app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();

app.Run();
