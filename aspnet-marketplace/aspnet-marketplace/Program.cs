using Microsoft.EntityFrameworkCore;
using aspnet_marketplace.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MarketplaceContext>(opt => opt.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MarketplaceDb"));

var app = builder.Build();

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}");

app.Run();
