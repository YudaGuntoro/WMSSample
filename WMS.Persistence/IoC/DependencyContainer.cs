using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Persistence.Services.CheckStockServices;
using WMS.Persistence.Services.StockInServices;
using WMS.Persistence.Services.StockOutService;
using WMS.Persistence.Services.UserServices;
using WMS.Repository.CheckStockRepository;
using WMS.Repository.StockInRepository;
using WMS.Repository.StockOutRepository;
using WMS.Repository.UserRepository;

namespace WMS.Persistence.IoC
{
    public static class DependencyContainer
    {
        public static void AddIoCService(this IServiceCollection services)
        {
            // IoC - Inversion Of Control

            // Application
            // -> Calling.Repository
            services.AddScoped<ICheckStockService, CheckStockService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IStockInService, StockInService>();
            services.AddScoped<IStockOutService, StockOutService>();


            // -> Calling.Persistence.Services
            services.AddScoped<ICheckStockRepository, CheckStockRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IStockInRepository, StockInRepository>();
            services.AddScoped<IStockOutRepository, StockOutRepository>();
        }
    }
}
