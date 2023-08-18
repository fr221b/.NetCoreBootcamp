using Microsoft.AspNetCore.Authentication.Cookies;
using Session17.Admin.Controllers;
using Session17.Models.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication().AddCookie(x =>
     x.LoginPath="/Home/AccessDenied"
);


builder.Services.AddDbContext<Context>();
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

app.UseAuthentication();
app.UseAuthorization();



app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

app.MapAreaControllerRoute(
    name: "UserPanel",
    areaName: "UserPanel",
    pattern: "UserPanel/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
