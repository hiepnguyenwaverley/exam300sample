using Manage_CoffeeShop.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Data.Entity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//add
//builder.Services.AddSingleton<IUserService, UserService>();



builder.Services.AddDbContext<DB_Entities>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DB_Entities")));
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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
