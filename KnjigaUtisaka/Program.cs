    using Microsoft.EntityFrameworkCore;

    namespace KnjigaUtisaka
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                var builder = WebApplication.CreateBuilder(args);

                // Add services to the container.
                builder.Services.AddRazorPages();


                builder.Services.AddScoped<UtisakServis>();

                builder.Services.AddDbContext<UtisakContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default") ?? throw
    new InvalidOperationException("Connection string 'Default' not found.")));

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

                app.UseAuthorization();

                app.MapRazorPages();

                app.Run();
            }
        }
    }