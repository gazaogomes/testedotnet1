using LubyDesafio.Data.Context;
using LubyDesafio.Data.Repositories;
using LubyDesafio.Data.Repositories.Interfaces;
using LubyDesafio.Services;
using LubyDesafio.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace LubyDesafio
{
    public static class Bootstrapper
    {
        public static void RegisterServices(this IServiceCollection services)
        {

            services.AddScoped<LubyDesafioContext>();

            RegisterDomainServices(services);
            RegisterRepositories(services);

        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<IDeveloperRepository, DeveloperRepository>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<ITimeEntryRepository, TimeEntryRepository>();
        }

        private static void RegisterDomainServices(IServiceCollection services)
        {
            services.AddScoped<IDeveloperService, DeveloperService>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<ITimeEntryService, TimeEntryService>();


        }
    }
}
