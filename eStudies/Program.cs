using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using eStudies.Data;
using eStudies.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<eStudiesDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("eStudiesDbContext") ?? throw new InvalidOperationException("Connection string 'eStudiesDbContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IEmailSender, EmailSender>();

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
    pattern: "{controller=UserTypes}/{action=Index}/{id?}");

app.Run();
