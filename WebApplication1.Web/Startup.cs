﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using WebApplication1.Common;
using WebApplication1.Data;
using WebApplication1.Services.Domain;
using WebApplication1.Services.Domain.Interfaces;

namespace WebApplication1.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddDbContext<SpongebobContext>(config => config.UseSqlServer("Data Source=juras-test.c4xkepfsjmb4.us-east-1.rds.amazonaws.com,11433;Initial Catalog=SpongebobDatabase;uid=su;pwd=P4ssw0rd!;"));

        
            
            
            ConfigureDomainServices(services);
        }

        private void ConfigureDomainServices(IServiceCollection services)
        {
            services.TryAddScoped<IEpisodeService, EpisodeService>();
            services.TryAddScoped<ICharacterService, CharacterService>();
            services.TryAddScoped<ISeasonService, SeasonService>();
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

            app.UseHttpsRedirection();
            app.UseMvc();
        }
        
        
    }
}