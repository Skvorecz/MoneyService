using Microsoft.EntityFrameworkCore;
using MoneyService;
using MoneyService.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<IMoneyContext, MoneyContext>(options =>
                                    options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Money"));
builder.Services.AddScoped<IExpensesService, ExpensesService>();
builder.Services.AddHealthChecks();

var app = builder.Build();
app.MapHealthChecks("/health");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
