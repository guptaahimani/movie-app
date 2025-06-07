using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Movie_app_api.DbContext;
using Movie_app_api.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration
    .AddJsonFile("appSettings.json", optional: true, reloadOnChange: true);

// Add services to the container.
builder.Services.AddDbContext<MovieDbContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("MovieAppDb")
    ));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<MovieDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
