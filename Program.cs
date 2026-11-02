//import namespaces to be able to use EF Core
using Microsoft.EntityFrameworkCore;
// to be able acess to InsuraDbContext in Data Folder
using InsuraV2.Data;
// to be able acess to different Repos that i'm used 
using InsuraV2.Repositories;
// to be able acess to Services that i'm used 
using InsuraV2.Services;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
var builder = WebApplication.CreateBuilder(args);
// put Controllers and Vies and MVC in DI Container , without this service controllers and views aren't work
builder.Services.AddControllersWithViews();
builder.Services.AddLocalization(options =>
{ options.ResourcesPath ="Resources"; } );
builder.Services.Configure<RequestLocalizationOptions>(options =>
{  var supportedCultures = new[]                 
    {   new CultureInfo("en"),
        new CultureInfo("ar")
        };                                 
    options.DefaultRequestCulture =                
        new RequestCulture("en");                  
    options.SupportedCultures =                                
        supportedCultures;              
    options.SupportedUICultures =                     
        supportedCultures;     }                     
);
//repear Database to use SQL Server as a DB , and take connection string from (appsettings.json) file
builder.Services.AddDbContext<InsuraDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));
//AddScoped -> it links the interface to the implementation and enables dependency injection work, then understand URL, and It interprets the URL and routes it to the appropriate controller and action.

builder.Services.AddScoped<OcrService>();
//Activate Sessions to store informations during i'm exchange between portal bages
builder.Services.AddSession();
//create the app
var app = builder.Build();
app.UseSession();
if (!app.Environment.IsDevelopment())
{   //if user find error, take him back to home bage 
    app.UseExceptionHandler("/Home/Error");
    //The site mandates the use of [feature/protocol] to enhance security.
    app.UseHsts();         }
// if user login with (//hhtp:) direct convert it to (//https:)
app.UseHttpsRedirection();
//To be able to play content of wwwroot files such as : js, css, images and bootstrap
app.UseStaticFiles();
//Routing -> the process of making the Server know which Action() or Controller
app.UseRouting();
//responsible of (what each user can do ?)
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");
app.Run();