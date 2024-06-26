using DevIo.Api.Adapters;
using DevIo.Api.Configurations;
using DevIo.Api.Dtos;
using DevIo.Api.Dtos.Request;
using DevIo.Api.Dtos.Response;
using DevIo.Api.Exceptions;
using DevIo.Api.Services;
using DevIo.Api.Utils.ApplicationSettings;
using DevIo.Api.Validators;
using DevIo.Business.Interfaces;
using DevIo.Business.Interfaces.Services;
using DevIo.Business.Model;
using DevIo.Infra.Database;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

builder.Services.Configure<ApplicationConfig>(configuration);
var applicationConfig = configuration.Get<ApplicationConfig>();

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IAdapter<SupplierCreateDto, Supplier>, CreateSupplierAdapter>();
builder.Services.AddScoped<IAdapter<Supplier, SupplierResponseDto>, GetSupplierAdapter>();
builder.Services.AddScoped<IAdapter<Product, ProductDto>, GetProductAdapter>();
builder.Services.AddTransient<IValidator<SupplierCreateDto>, SupplierCreateDtoValidator>();
builder.Services.AddScoped<ICreateService<SupplierCreateDto, Supplier>, CreateSupplierService>();
builder.Services.AddScoped<IGetSupplierByIdService<Supplier>, GetSupplierByIdService>();
builder.Services.AddScoped<ApiDbContext>();
builder.Services.ConfigureRepositoryServices();


builder.Services.AddDbContext<ApiDbContext>(optionsAction: options =>
{
    if (applicationConfig?.ConnectionStrings?.DefaultConnection is null)
    {
        throw new MissingConfigurationException("DefaultConnection");
    }
    options.UseSqlServer(applicationConfig.ConnectionStrings.DefaultConnection);
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        var context = services.GetRequiredService<ApiDbContext>();
        var loggerFactory = services.GetRequiredService<ILoggerFactory>();
        try
        {
            await context.Database.MigrateAsync();
            //await ApiDbContextSeed.SeedAsync(context);
        }
        catch (Exception exception)
        {
            var logger = loggerFactory.CreateLogger<Program>();
            logger.LogError(exception, "An error occured during migration");
        }
    }
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
