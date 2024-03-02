using DevIo.Business.Interfaces.Repositories;
using DevIo.Infra.Repositories;

namespace DevIo.Api.Configurations
{
    internal static class RepositoriesConfiguration
    {
        internal static IServiceCollection ConfigureRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped<ISupplierRepository, SupplierRepository>();
            //services.AddScoped<>();
            //services.AddScoped<>();

            return services;
        }
    }
}
