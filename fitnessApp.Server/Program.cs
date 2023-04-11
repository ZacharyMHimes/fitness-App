using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using fitnessApp.Server.Data;
using Microsoft.EntityFrameworkCore;
using fitnessApp.Services.IServices;
using fitnessApp.Services.Services;
using fitnessApp.Data;
using fitnessApp.Data.DBContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IUserService,UserService>();
builder.Services.AddScoped<ILogBookService,LogBookService>();
builder.Services.AddScoped<ILogService,LogService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
