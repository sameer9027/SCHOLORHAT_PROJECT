using Microsoft.EntityFrameworkCore;
using ScholorHat_api.Data;
using ScholorHat_api.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MyDBContext>(items => items.UseSqlServer(builder.Configuration.GetConnectionString("constr")));
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();



builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
