using DBConfig.Abstract;
using DBConfig.Factory;
using Ferramas.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

ConfigureSevices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute
(
    name:"default",
    pattern: "{controller=home}/{action=index}/{id?}"
);

app.Run();


void ConfigureSevices()
{
    IConfigurationSection dbSection = builder.Configuration.GetSection("DBConnection");
    IDBConnectionData connectionData = DBConnectionFactory.CreateDBConnectionData(dbSection);
    builder.Services.AddDbContextPool<FerraContext>(options => options.UseSqlServer(connectionData.ConnectionString));

    builder.Services.AddControllersWithViews();
}