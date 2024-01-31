using Microsoft.EntityFrameworkCore;
using Movies.Entities;
using System.Data.Common;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//var connstr = builder.Configuration.GetConnectionString("MovieConnetionString");
//builder.Services.AddDbContext<MovieDbContext>(option => option.UseSqlServer(connstr));


builder.Services.AddDbContext<MovieDbContext>(option =>
    option.UseSqlServer(builder.Configuration.GetConnectionString("MovieConnectionString"))
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
