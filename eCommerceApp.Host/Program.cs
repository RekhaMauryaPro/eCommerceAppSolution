using eCommerceApp.Infrastructure.DependencyInjection;
using eCommerceApp.Application.DependencyInjection;
using eCommerceApp.Host.Components;
using eCommerceApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
//builder.Services.AddDbContextPool<AppDbContext>(builder =>
//{
//   // var connectionString =builder..GetConnectionString("Database");
//    builder.UseSqlServer(("Server=DESKTOP-LCDV0UT\\SQLEXPRESS;Database=eCommerceAppDb;Trusted_Connection=true;Encrypt=false;"));
//});
builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
builder.Services.AddInfrastructureService(builder.Configuration);
builder.Services.AddApplicationService();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
