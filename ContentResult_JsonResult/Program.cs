var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{Id?}");
app.MapControllerRoute("default", "{controller=Home}/{action=Json}/{Id?}");

app.Run();
