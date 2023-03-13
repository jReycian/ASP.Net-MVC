using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Demo3.Data;
using Demo3.Areas.Identity.Data;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Demo3DBContextConnection") ?? throw new InvalidOperationException("Connection string 'Demo3DBContextConnection' not found.");

builder.Services.AddDbContext<Demo3DBContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<Demo3DBContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<HomeDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HomeDBContext") ?? throw new InvalidOperationException("Connection string 'HomeDBContext' not found.")));

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
