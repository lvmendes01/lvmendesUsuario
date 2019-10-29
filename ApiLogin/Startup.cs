using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lvmendes.Repositorios.Interfaces;
using lvmendes.Servicos.Interfaces;
using lvmendes.Servicos.Servicos;
using Lvmendes.Repositorios.Repositorios;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ApiLogin
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info
                {
                    Version = "v1",
                    Title = "ToDo API",
                    Description = "A simple example ASP.NET Core Web API",
                    TermsOfService = new Uri("https://example.com/terms").ToString(),
                    Contact = new Swashbuckle.AspNetCore.Swagger.Contact
                    {
                        Name = "Shayne Boyer",
                        Email = string.Empty,
                        Url = new Uri("https://twitter.com/spboyer").ToString(),
                    },
                    License = new Swashbuckle.AspNetCore.Swagger.License
                    {
                        Name = "Use under LICX",
                        Url = new Uri("https://example.com/license").ToString(),
                    }
                });
            });

            services.AddSingleton<ISistemaServico, SistemaServico>();
            services.AddSingleton<IPerfilServico, PerfilServico>();
            services.AddSingleton<IUsuarioServico, UsuarioServico>();


            services.AddSingleton<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddSingleton<IPerfilRepositorio, PerfilRepositorio>();
            services.AddSingleton<ISistemaRepositorio, SistemaRepositorio>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseSwagger();
            app.UseHttpsRedirection();
           app.UseMvc();
        }
    }
}
