using APIxCapas.Interface;
using APIxCapas.Models;
using APIxCapas.Repository;
using APIxCapas.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIxCapas.Middleware
{
    public static class IoC
    {

        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            services.AddTransient<ICommerceRepository<Product>, CommerceRepository<Product>>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ICommerceRepository<Client>, CommerceRepository<Client>>();
            services.AddTransient<IClientService, ClientService>();
            return services;

        }

    }
}
