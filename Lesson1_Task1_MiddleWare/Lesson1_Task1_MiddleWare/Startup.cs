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
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebStore.DAL;
using WebStore.Domain.Entities;

namespace Lesson1_Task1_MiddleWare
{
    public class Startup
    {
        private readonly IConfiguration _confiuration;
        public Startup(IConfiguration confiuration)
        {
            _confiuration = confiuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddDbContext<WebStoreContext>(options => options.UseSqlServer(_confiuration.GetConnectionString("DefaultConnection")));

            // Добавляем разрешение зависимости
            services.AddSingleton<IStudentsService, InMemoryStudentsData>();
            //services.AddSingleton<IProductService, InMemoryProductService>();
            services.AddScoped<IProductService, SqlProductData>();

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<WebStoreContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
                {
                    options.Password.RequireDigit = false;
                    options.Password.RequiredLength = 6;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.User.RequireUniqueEmail = true;
                    options.User.AllowedUserNameCharacters = "абвгдеёжзийклмнопрстуфхцчшщьыъэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЭЮЯ" +
                                                              "abcdefghijklmnopqrstuwvxyzABCDEFGHIJKLMNOPQRSTUWVXYZ"+
                                                              "1234567890-._@+";

                    options.Lockout.AllowedForNewUsers = true;
                    options.Lockout.MaxFailedAccessAttempts = 5;
                    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(20); /*Возвращает или задает TimeSpan, на который блокируется
                                                                                        * пользователь при возникновении блокировки. По умолчанию
                                                                                        * 5 минут.*/
                });

            services.ConfigureApplicationCookie(options =>
               {
                   options.Cookie.HttpOnly = true;

                   options.LoginPath = "/Account/Login";
                   options.LogoutPath = "/Account/Logout";
                   options.AccessDeniedPath = "/Account/AccessDenied";
                   options.SlidingExpiration = true;
                   options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
               });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) //Есди среда - Development
            {
                app.UseDeveloperExceptionPage(); //Подробная инф-я об ошибке.
            }

            app.UseAuthentication();

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
