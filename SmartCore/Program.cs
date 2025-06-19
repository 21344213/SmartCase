using ISmartInfrasture;
using ISmartServices;
using Microsoft.EntityFrameworkCore;
using SmartInfrastructure;
using SmartServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IApperovalServices), typeof(ApperovalServices));

builder.Services.AddDbContext<BaseDataDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("Conn"));
});
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
