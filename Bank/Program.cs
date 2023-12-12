
using Bank.Core.Repositories;
using Bank.Core.Services;
using Bank.Entities;
using Bank.Controllers;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IBank_AccountRepository, Bank_AccountRepository>();
builder.Services.AddScoped<ICustomerRepository,CustomerRepository>();
builder.Services.AddScoped<IOfficialRepository,OfficialRepository>();

builder.Services.AddScoped<IBank_AccountService, Bank_AccountService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IOfficialService, OfficialService>();
builder.Services.AddSingleton<DataContext>();
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
