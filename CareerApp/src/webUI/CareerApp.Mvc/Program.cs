
using CareerApp.Infrastructure.Data;
using CareerApp.Infrastructure.Repositories;
using CareerApp.Mvc.Controllers;
using CareerApp.Services;
using CareerApp.Services.Mappings;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<CareerAppDbContext>();

builder.Services.AddScoped<ICompanyRepository,EFCompanyRepository>();
builder.Services.AddScoped<IJobSeekerRepository,EFJobSeekerRepository>();
builder.Services.AddScoped<IJobPostingRepository,EFJobPostingRepository>();
builder.Services.AddScoped<IRecourseRepository,EFRecourseRepository>();
builder.Services.AddScoped<ICityRepository,EFCityRepository>();
builder.Services.AddScoped<IJobRepository,EFJobRepository>();

builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IJobSeekerService, JobSeekerService>();
builder.Services.AddScoped<IJobPostingService, JobPostingService>();
builder.Services.AddScoped<IRecourseServices, RecourseService>();
builder.Services.AddScoped<ICityService, CityService>();
builder.Services.AddScoped<IJobService, JobService>();

builder.Services.AddAutoMapper(typeof(MapProfile));

builder.Services.AddSession();



builder.Services.AddSession(options =>
{
    options.Cookie.Name = "Username";
    options.IdleTimeout = TimeSpan.FromMinutes(30);
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
