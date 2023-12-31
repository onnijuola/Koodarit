using NToastNotify;
using Microsoft.Extensions.DependencyInjection;


internal class Program
{
    [Obsolete]
    private static void Main(string[] args)
    {
        
        






        var builder = WebApplication.CreateBuilder(args);


        // Add services to the container.
        builder.Services.AddRazorPages().AddNToastNotifyNoty(new NotyOptions
        {
            ProgressBar = true,
            Timeout = 5000
        });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        Console.WriteLine("Hello, Oskari");

        Console.WriteLine("Hello, Jesse");

        Console.WriteLine("Hello, Niko");

        Console.WriteLine("hello onni");

        Console.WriteLine("HELLO Antti");

        Console.WriteLine("Conflict Harjoitus");

        app.UseHttpsRedirection();

        app.UseStaticFiles();

        app.UseNToastNotify();

        app.UseRouting();

        app.UseAuthorization();

        app.MapRazorPages();

        app.Run();





    }
}