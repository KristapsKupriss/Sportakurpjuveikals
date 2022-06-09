using Microsoft.EntityFrameworkCore;
using Sports.Data;
using Sports.Services;







var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql("Server=localhost;Port=5432;Database=demodb;User Id=postgres;Password=11111111"));

builder.Services.AddScoped<BernuSA>();
builder.Services.AddScoped<SievFutB>();
builder.Services.AddScoped<SievSkrA>();
builder.Services.AddScoped<VirFutB>();
builder.Services.AddScoped<VirSkrA>();
builder.Services.AddScoped<BernufutbolaBucu>();
builder.Services.AddScoped<BKurp>();
builder.Services.AddScoped<SKurp>();
builder.Services.AddScoped<VKurp>();
builder.Services.AddScoped<JaunasK>();
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
