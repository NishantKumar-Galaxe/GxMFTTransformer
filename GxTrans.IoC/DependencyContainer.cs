using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using GxTrans.Application.Services;
using GxTrans.Application.Interfaces;



namespace GxTrans.Infra.IoC
{
    public static class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IJScapeService, JScapeService>();
            services.AddScoped<IMOVEitService, MOVEitService>();
        }
    }
}
