using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

using GxTrans.Application.Services;
using GxTrans.Application.Interfaces;

using GxTrans.Infra.Data.Repository;
using GxTrans.Domain.Interfaces;

namespace GxTrans.Infra.IoC
{
    public static class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Resolve Services
            services.AddScoped<IJScapeService, JScapeService>();
            services.AddScoped<IMOVEitService, MOVEitService>();

            //Resolve Repositories
            services.AddScoped<IJScapeRepository, JScapeRepository>();
            services.AddScoped<IMOVEitRepository, MOVEitRepository>();

            
        }
    }
}
