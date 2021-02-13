using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GxTrans.Infra.Data.Context;
using GxTrans.Infra.IoC;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace GxTrans.Presentation
{
    static class Program
    {
        public static IConfiguration Configuration { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            configureService();
        }

        public static void configureService()
        {
           
            var builder = new HostBuilder()
             .ConfigureServices((hostContext, services) =>
             {
                 services.AddSingleton<Form1>();
                 services.AddLogging(configure => configure.AddConsole());

                 services.AddDbContext<TransDBContext>(options =>
                 {
                     options.UseSqlServer(ConfigurationManager.ConnectionStrings["dbConnectionString"].ConnectionString);
                 });

                 RegisterServices(services);

             });

            var host = builder.Build();
            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    var form1 = services.GetRequiredService<Form1>();
                    System.Windows.Forms.Application.Run(form1);

                    Console.WriteLine("Success");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Some Error Occured");
                }
            }
        }

        private static void RegisterServices(IServiceCollection services)
        {
            DependencyContainer.RegisterServices(services);
        }
    }
}
