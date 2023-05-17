var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
var app = builder.Build();

var message = app.Configuration.GetSection("Message")["meet"];

//app.MapGet("/", () => message);

app.UseRouting();
app.MapControllerRoute("default","{controller=Home}/{action=Index}/{id?}");

app.Run();
