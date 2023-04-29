﻿using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace ApiGateway
{
    internal class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddOcelot();
        }

        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseOcelot().Wait();
        }
    }
}