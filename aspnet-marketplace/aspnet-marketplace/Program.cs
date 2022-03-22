using Microsoft.EntityFrameworkCore;
using aspnet_marketplace.Data;
using aspnet_marketplace.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MarketplaceContext>(opt => opt.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MarketplaceDb"));
builder.Services.AddScoped<IAdService, AdService>();

var app = builder.Build();

app.UseStaticFiles();
app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}");

app.Run();
