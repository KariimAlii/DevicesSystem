using DevicesSystem.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
namespace DevicesSystem.PresentationLayer.Extensions
{
    public static class RepoServiceExtensions
    {
        public static IServiceCollection AddRepoServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepo, CategoryRepo>();
            services.AddScoped<IDeviceRepo, DeviceRepo>();
            services.AddScoped<IPropertyRepo, PropertyRepo>();
            services.AddScoped<IUserRepo, UserRepo>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
