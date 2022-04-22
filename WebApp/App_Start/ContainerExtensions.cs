using BD;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBL;

namespace WebApp
{
    public static class ContainerExtensions
    {
        public static IServiceCollection AddDIContainer(this IServiceCollection services)
        {
            services.AddSingleton<IDataAccess, DataAccess>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<ISolicitudService, SolicitudService>();
            services.AddScoped<IServicioService, ServicioService>();
            
            return services;
        }
    }
}
