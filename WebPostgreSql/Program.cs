using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Globalization;
using WebPostgreSql.Models;

namespace WebPostgreSql
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            builder.Services.AddEntityFrameworkNpgsql().AddDbContext<Contexto>(options => options.UseNpgsql("Host=localhost;Port=5432;Pooling=true;Database=CRUD_POSTGRES;User Id=postgres;Password=Moca_0502;"));

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            // Configuração de cultura
            var cultureInfo = new CultureInfo("en-US"); // Configuração para usar ponto como separador decimal
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            app.Run();
        }
    }
}
