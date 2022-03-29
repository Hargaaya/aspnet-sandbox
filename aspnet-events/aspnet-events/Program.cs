using Microsoft.EntityFrameworkCore;
using aspnet_events.Data;
using aspnet_events.Services;
using aspnet_events.Models;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
/*
builder.Services.AddDbContext<EventsContext>(options => options.
UseLazyLoadingProxies().
UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EventsDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));

builder.Services.AddScoped<IEventsService, EventsService>();
*/

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EventsDb2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));
builder.Services.AddIdentity<User, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<AppDbContext>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}");

app.Run();
