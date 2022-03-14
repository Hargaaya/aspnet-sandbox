using Microsoft.EntityFrameworkCore;
using aspnet_events.Data;
using aspnet_events.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<EventsContext>(options => options.
UseLazyLoadingProxies().
UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EventsDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));

builder.Services.AddScoped<IEventsService, EventsService>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}");

app.Run();
