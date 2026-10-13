using GMS_Matthew_Storti.DataAccessLayer;
using GMS_Matthew_Storti.Services;
using Microsoft.EntityFrameworkCore;

namespace GMS_Matthew_Storti;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorPages();

        builder.Services.AddDbContext<GroceryDBContext>(
            options=>options.UseSqlite(builder
            .Configuration
            .GetConnectionString("GroceryConnection"))
            );

        builder.Services.AddScoped<IGroceryItemService, GroceryItemService>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
        }

        app.UseRouting();

        app.UseAuthorization();

        app.MapStaticAssets();
        app.MapRazorPages()
           .WithStaticAssets();

        app.Run();
    }
}
