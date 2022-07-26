global using Microsoft.EntityFrameworkCore;
using Products.Persistence.Context;
using MediatR;
using System.Reflection;
using Products.Application.Products.AddProduct;
using Products.Application.Services;
using Products.Application.Services.Implementations;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), 
        x => x.MigrationsAssembly(typeof(AppDbContext).GetTypeInfo().Assembly.GetName().Name));
});

//builder.Services.AddMediatR(typeof(Program));
builder.Services.AddMediatR(typeof(AddProductCommand));
builder.Services.AddControllers()
    .AddFluentValidation(fv =>
    {
        fv.ImplicitlyValidateChildProperties = true;
        fv.ImplicitlyValidateRootCollectionElements = true;

       // fv.RegisterValidatorsFromAssembly(typeof(AddProductCommand).GetTypeInfo().Assembly);

                // Other way to register validators
                fv.RegisterValidatorsFromAssemblyContaining<Program>();
    });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//services
builder.Services.AddTransient<IMathService, MathService>();

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
