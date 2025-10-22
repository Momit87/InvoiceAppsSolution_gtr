using InvoiceApps.Api.Data;
using InvoiceApps.Api.Models;
using InvoiceApps.Api.Repositories.Implementations;
using InvoiceApps.Api.Repositories.Interfaces;
using InvoiceApps.Api.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Configure DbContext with connection string
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

// Configure Identity
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(opts =>
{
    opts.Password.RequireDigit = false;
    opts.Password.RequireUppercase = false;
    opts.Password.RequireNonAlphanumeric = false;
    opts.Password.RequiredLength = 6;
})
.AddEntityFrameworkStores<AppDbContext>()
.AddDefaultTokenProviders();

// Dependency injections
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<DapperReadService>();

// Add controllers
builder.Services.AddControllers();

// API documentation support (Swagger)
builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c =>
{
    c.SupportNonNullableReferenceTypes();
    c.OperationFilter<FileUploadOperationFilter>(); // Add this line
});

// CORS policy allowing all origins (for local development)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocal", policy =>
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader());
});

var app = builder.Build();

// Developer exception and swagger UI in Development
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Use HTTPS redirection for security
app.UseHttpsRedirection();

// Middleware order
app.UseRouting();

app.UseCors("AllowLocal");

app.UseAuthentication();
app.UseAuthorization();

// Map controllers and root
app.MapControllers();
app.MapGet("/", () => "InvoiceApps API is running...");

app.Run();
