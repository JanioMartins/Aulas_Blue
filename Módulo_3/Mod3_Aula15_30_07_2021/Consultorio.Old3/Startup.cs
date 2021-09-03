using Consultorio.Data;
using Consultorio.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Consultorio
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            // Quando add um contexto, o addtransient também é executado
            services.AddDbContext<ConsultorioContext>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("Consultorio"))
            );


            // AddTransient é responsável por falar para o framework que,
            // quando a interface for necessária, seja utilizada a classe

            //services.AddTransient<IPacienteService, PacienteStaticService>();
            services.AddTransient<IPacienteService, PacienteSqlService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    // classe / método 
                    // ProdutoController -> Criar  -- 
                    // Home / Index 
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
