using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson1_Task1_MiddleWare.InfroStrucure;
using Lesson1_Task1_MiddleWare.InfroStrucure.Interfaces;
using Lesson1_Task1_MiddleWare.InfroStrucure.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Lesson1_Task1_MiddleWare
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            // Добавляем разрешение зависимости
            services.AddSingleton<IStudentsService, InMemoryStudentsData>();
            services.AddSingleton<IProductService, InMemoryProductService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) //Есди среда - Development
            {
                app.UseDeveloperExceptionPage(); //Подробная инф-я об ошибке.
            }

            app.UseStaticFiles();

            app.UseRouting();

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("No handler found for this request...");
            //});

            app.UseWelcomePage("/Welcome");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            //app.UseWelcomePage(); /*Конвейер обработки запросов MVC выполниться первым вместо UseWelcomePage()*/
        }
    }
}
