using Notes.Models.Configure;
using Notes.Models.Contex;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        //Тут правильно все сделал
        var config = GetConfig();
        var builder = WebApplication.CreateBuilder(args);
        


        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();
        builder.Services.AddSingleton(config);
        builder.Services.AddSingleton<NoteDbContext>();



        var app = builder.Build();


        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");

            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();

        app.UseRouting();

        app.MapBlazorHub();
        app.MapFallbackToPage("/_Host");

        app.Run();

    }
    static ServiceConfigure GetConfig()
    {
        string file = File.ReadAllText("appsettings.json");
        return JsonSerializer.Deserialize<ServiceConfigure>(file);
    }
}