using Microsoft.EntityFrameworkCore;
using AspNet.Data;
using System.Configuration;


// Remova a refer�ncia ao namespace System.Configuration, pois n�o � necess�ria aqui

var builder = WebApplication.CreateBuilder(args);
var serverVersion = new MySqlServerVersion(new Version(8, 0, 23));
builder.Services.AddDbContext<AspNetContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("AspNetContext"), serverVersion));
;


// O restante do seu c�digo permanece inalterado

builder.Services.AddScoped<SeedingService>();
// Add services to the container.
builder.Services.AddControllersWithViews();
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
