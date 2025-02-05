﻿using eCommerceApp.Domain.Interfaces;
using eCommerceApp.Domain.Entities;
using eCommerceApp.Infrastructure.Data;
using eCommerceApp.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerceApp.Infrastructure.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration config)
        {
            string connectionString = "Default";
           // services.AddDbContext<AppDbContext>();
            services.AddScoped<AppDbContext>();
           // services.AddDbContext<AppDbContext>(option =>
            //option.UseSqlServer(config.GetConnectionString(connectionString)));
            //sqlOptions =>
            //{

            //    sqlOptions.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName);
            //    sqlOptions.EnableRetryOnFailure();

            //}),
            //ServiceLifetime.Scoped);
           // );
            services.AddScoped<IGeneric<Product>,GenericRepository<Product>>();
            services.AddScoped<IGeneric<Category>,GenericRepository<Category>>();
            return services;
        }
    }
}
