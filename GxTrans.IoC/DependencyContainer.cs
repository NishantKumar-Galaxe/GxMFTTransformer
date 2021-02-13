using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace GxTrans.Infra.IoC
{
    public static class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer 
            //services.AddScoped<ICourseService, CourseService>();

            //Infra.Data Layer
            //services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
