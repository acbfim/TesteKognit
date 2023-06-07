
using kognito.repository;
using kognito.repository.Contracts;
using kognito.repository.Data;
using kognito.service;
using kognito.service.Contracts;

namespace kognito.api.Extensions
{
    public static class ConfigServiceCollectionExtensions
    {
        public static IServiceCollection AddMyDependencyGroup(
         this IServiceCollection services)
        {
            services.AddScoped<IWalletRepository, WalletRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<IWalletService, WalletService>();
            services.AddScoped<IUserService, UserService>();




            return services;
        }
    }
}