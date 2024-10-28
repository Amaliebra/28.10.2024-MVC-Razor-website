using MVC_Website.Services;

namespace MVC_Website;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews();

        builder.Services.AddScoped<BlogPostService>();

        var app = builder.Build();

        app.MapGet("/", () => "Hello World!");



        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Main}/{action=Index}/{id?}");

        app.Run();
    }
}
