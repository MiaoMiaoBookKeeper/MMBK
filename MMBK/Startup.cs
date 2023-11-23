using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MMBK.Core.Contract;
using MMBK.Data;
using MMBK.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MMBK
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
            services.AddScoped<IDemoService, DemoService>();
         //   services.AddScoped<IBookService, BookService>();
         //   services.AddDbContext<BookDbContext>(options =>
         //           options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
         //   services.AddScoped<IBookRepository, BookRepository>();
         //   services.AddScoped<IDbMigrator, DbMigrator>();
            services.AddControllers();

          services.AddCors(options =>
          {
            options.AddPolicy("AllowSpecificOrigin",
                builder => builder.WithOrigins("http://localhost:4200")
                                  .AllowAnyHeader()
                                  .AllowAnyMethod());
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

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors("AllowSpecificOrigin"); // Apply the CORS policy

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
