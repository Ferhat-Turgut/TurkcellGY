using CourseApp.Infrastructure.Data;
using CourseApp.Infrastructure.Repositories;
using CourseApp.Mvc.Extensions;
using CourseApp.Services;
using CourseApp.Services.Mappings;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//Inversion Od Control (IoC)
builder.Services.AddAutoMapper(typeof(MapProfile));

builder.Services.AddSession(opt => 
{
    opt.IdleTimeout = TimeSpan.FromMinutes(15);
});

var connectionString = builder.Configuration.GetConnectionString("db");
builder.Services.AddInjections(connectionString);//extension yazd�k.(IoC Extensions)
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(opt =>
{
    opt.LoginPath = "/Users/Login";
    opt.AccessDeniedPath = "/Users/AccessDenied";
    opt.ReturnUrlParameter = "gidilecekSayfa";
});

//Caching
builder.Services.AddMemoryCache();//E�er istenen bilgi cashe te varsa al�r, yoksa normalde veriye ula��lan yol ile al�n�r.S�resi belirlenebilir.
builder.Services.AddResponseCaching(opt=>
{
opt.SizeLimit = 100000;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;
var context=services.GetRequiredService<CourseDbContext>();
context.Database.EnsureCreated();
DbSeeding.SeedDatabase(context);

app.UseHttpsRedirection();
app.UseResponseCaching();
app.UseStaticFiles();

app.UseSession();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
