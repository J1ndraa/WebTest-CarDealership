using Microsoft.EntityFrameworkCore;
using CarDealership.Models;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);

//path to sqllite database file
var dbPath = Path.Combine(Directory.GetCurrentDirectory(), "CarDealership.db");

//add database context
builder.Services.AddDbContext<DB_Context>(options =>
    options.UseSqlite($"Data Source={dbPath}"));

//using mvc model
builder.Services.AddControllersWithViews();

//configuration cookies
builder.Services.Configure<CookiePolicyOptions>(options =>
{
    //minimal SameSite policy for local testing and https
    options.MinimumSameSitePolicy = SameSiteMode.Lax;
    options.Secure = CookieSecurePolicy.Always;
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseCookiePolicy();
app.UseAuthorization();

//routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
