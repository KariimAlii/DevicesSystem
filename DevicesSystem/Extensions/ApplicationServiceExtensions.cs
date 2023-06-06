using Microsoft.EntityFrameworkCore;
using DevicesSystem.CoreLayer;
namespace DevicesSystem.PresentationLayer.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services) 
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                var LocalConnectionString = services.BuildServiceProvider().GetService<IConfiguration>().GetConnectionString("LocalConnectionString");
                options.UseSqlServer(LocalConnectionString);
            });
            return services;
        }
    }
}
