using Chat_ovaci_aplikace.Entities;
using Microsoft.EntityFrameworkCore;
using Chat_ovaci_aplikace.Database;


namespace Chat_ovaci_aplikace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            string connectionString = builder.Configuration.GetConnectionString("MySQL")
                    ?? throw new InvalidOperationException("MySQL connection string is not provided");

            builder.Services.AddDbContext<DatabaseContext>(options =>
                    options.UseMySQL(connectionString)
                );

            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.UseStaticFiles();

            app.UseAuthorization();

            app.UseSession();

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();

            app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}")
            .WithStaticAssets();


            app.Run();
        }
     }
}
