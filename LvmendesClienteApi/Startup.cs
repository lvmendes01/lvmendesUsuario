using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lvmendes.Cliente.Repositorio.Interfaces;
using Lvmendes.Cliente.Repositorio.Repositorios;
using Lvmendes.Cliente.Servico.Interfaces;
using Lvmendes.Cliente.Servico.Servicos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace LvmendesClienteApi
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
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", p =>
                {
                    p.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });
            services.AddControllers();


            services.AddTransient<IPessoaFisicaServico, PessoaFisicaServico>();
            services.AddTransient<IGeralServico, GeralServico>();


            services.AddTransient<IPessoaFisicaRepositorio, PessoaFisicaRepositorio>();
            services.AddTransient<IGeralRepositorio, GeralRepositorio>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "v1",
                    Title = "CLIENTE API",
                    Description = "API de CLIENTE",
                    TermsOfService = new Uri("https://example.com/terms"),
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact
                    {
                        Name = "linkedin",
                        Email = string.Empty,
                        Url = new Uri("https://www.linkedin.com/in/leonardo-vinicius-mendes-6379b342/"),
                    },
                    License = new Microsoft.OpenApi.Models.OpenApiLicense
                    {
                        Name = "github Fontes",
                        Url = new Uri("https://github.com/lvmendes01/lvmendesUsuario"),
                    }
                });
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseCors("AllowAll");
            app.UseRouting();

            app.UseAuthorization();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint($"/swagger/v1/swagger.json", "API CLIENTE");
                // c.SwaggerEndpoint($"/swagger/v1/swagger.json", "API USUARIO");
            });
            app.UseSwagger();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
