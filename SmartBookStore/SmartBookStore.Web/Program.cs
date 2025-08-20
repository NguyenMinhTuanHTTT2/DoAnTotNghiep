using Microsoft.EntityFrameworkCore;
using SmartBookStore.Data;
using SmartBookStore.Web.Service;
using Microsoft.AspNetCore.Components.Authorization;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<SmartBookStoreDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// AuthService
builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<AuthenticationStateProvider>(sp => sp.GetRequiredService<AuthService>());
builder.Services.AddAuthorizationCore();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
    app.UseExceptionHandler("/Error");

app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
